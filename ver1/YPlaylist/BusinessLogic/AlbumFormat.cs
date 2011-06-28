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
    class AlbumFormat : ActiveRecordBase<AlbumFormat>
    {
        private int FormatID;
        private string FormatName;
        private IList<Album> Album = new List<Album>();


        public AlbumFormat()
        {
        }

        public AlbumFormat(string fn)
        {
            this.FormatName = fn;
        }

        [PrimaryKey]
        private int formatID
        {
            get { return FormatID; }
            set { FormatID = value; }
        }

        [Property]
        public string formatName
        {
            get { return FormatName; }
            set { FormatName = value; }
        }

        [HasMany(
        Table = "Album", ColumnKey = "FormatID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> album
        {
            get { return Album; }
            set { Album = value; }
        }


        public static string[] ReturnAllFormatNames()
        {
            int lid = AlbumFormat.Count();

            string[] arr = new string[lid];

            AlbumFormat temp = new AlbumFormat();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("formatID") };

            AlbumFormat[] allids = (AlbumFormat[])AlbumFormat.FindAll(typeof(AlbumFormat), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (AlbumFormat)AlbumFormat.FindByPrimaryKey(typeof(AlbumFormat), allids[i].formatID);
                arr[counter] = (string)temp.formatName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static AlbumFormat GetFormatID(string fname)
        {
            ICriterion[] crit = { Expression.Eq("formatName", fname) };
            AlbumFormat t = (AlbumFormat)FindFirst(typeof(AlbumFormat), crit);
            return t;
        }

        internal static AlbumFormat[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }

    }
}
