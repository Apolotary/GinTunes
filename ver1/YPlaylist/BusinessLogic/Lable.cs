using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using Castle.Components;
using System.Linq;
using System.Text;
using Castle.ActiveRecord.Queries;
using NHibernate;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    class Lable : ActiveRecordBase<Lable>
    {
        private int LableID;
        private string LableName;
        private IList<Album> Album = new List<Album>();

        public Lable()
        {
        }

        public Lable(string LableName)
        {
            this.LableName = LableName;
        }

        [PrimaryKey]
        private int lableID
        {
            get { return LableID; }
            set { LableID = value; }
        }

        [Property]
        public string lableName
        {
            get { return LableName; }
            set { LableName = value; }
        }

        [HasMany(
        Table = "Album", ColumnKey = "LableID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> album
        {
            get { return Album; }
            set { Album = value; }
        }
        
        public static string[] ReturnAllLableNames()
        {
            int lid = Lable.Count();

            string[] arr = new string[lid];

            Lable temp = new Lable();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("lableID") };

            Lable[] allids = (Lable[])Lable.FindAll(typeof(Lable), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Lable)Lable.FindByPrimaryKey(typeof(Lable), allids[i].lableID);
                arr[counter] = (string)temp.lableName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        /*
        public static Lable[] ReturnAllLableNames()
        {
            SimpleQuery<Lable> q = new SimpleQuery<Lable>(@"
            select l.lableName
            from Lable l
            ");
            return q.Execute();
        }*/


        public static Lable GetLableID(string lname)
        {
            ICriterion[] crit = { Expression.Eq("lableName", lname) };
            Lable t = (Lable)FindFirst(typeof(Lable), crit);
            return t;
        }

        internal static Lable[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }
    }
}
