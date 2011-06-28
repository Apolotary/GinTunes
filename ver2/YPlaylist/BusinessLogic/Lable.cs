using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class Lable : ActiveRecordBase<Lable>
    {
        private IList<Album> _album = new List<Album>();

        public Lable()
        {
        }

        public Lable(string LableName)
        {
            this.LableName = LableName;
        }

        [PrimaryKey]
        private int LableId { get; set; }

        [Property]
        public string LableName { get; set; }

        [HasMany(
        Table = "Album", ColumnKey = "LableID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> album
        {
            get { return _album; }
            set { _album = value; }
        }
        
        public static string[] ReturnAllLableNames()
        {
            int lid = Lable.Count();

            string[] arr = new string[lid];

            Lable temp;
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("LableId") };

            Lable[] allids = (Lable[])Lable.FindAll(typeof(Lable), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Lable)Lable.FindByPrimaryKey(typeof(Lable), allids[i].LableId);
                arr[counter] = (string)temp.LableName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static Lable GetLableId(string lname)
        {
            ICriterion[] crit = { Expression.Eq("LableName", lname) };
            Lable t = (Lable)FindFirst(typeof(Lable), crit);
            return t;
        }

        internal static Lable[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }
    }
}
