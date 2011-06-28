using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class AlbumFormat : ActiveRecordBase<AlbumFormat>
    {
        private IList<Album> _album = new List<Album>();

        public AlbumFormat()
        {
        }

        public AlbumFormat(string fn)
        {
            this.FormatName = fn;
        }

        [PrimaryKey]
        private int FormatId { get; set; }

        [Property]
        public string FormatName { get; set; }

        [HasMany(
        Table = "Album", ColumnKey = "FormatID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> Album
        {
            get { return _album; }
            set { _album = value; }
        }

        public static string[] ReturnAllFormatNames()
        {
            int lid = AlbumFormat.Count();

            string[] arr = new string[lid];

            AlbumFormat temp = new AlbumFormat();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("FormatId") };

            AlbumFormat[] allids = (AlbumFormat[])AlbumFormat.FindAll(typeof(AlbumFormat), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (AlbumFormat)AlbumFormat.FindByPrimaryKey(typeof(AlbumFormat), allids[i].FormatId);
                arr[counter] = (string)temp.FormatName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static AlbumFormat GetFormatId(string fname)
        {
            ICriterion[] crit = { Expression.Eq("FormatName", fname) };
            AlbumFormat t = (AlbumFormat)FindFirst(typeof(AlbumFormat), crit);
            return t;
        }

        internal static AlbumFormat[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }
    }
}
