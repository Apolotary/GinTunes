using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class Genre : ActiveRecordBase<Genre>
    {
        private IList<Artist> _artist = new List<Artist>();

        public Genre()
        {
        }

        public Genre(string gName)
        {
            this.GenreName = gName;
        }

        [PrimaryKey]
        public int GenreId { get; set; }

        [Property]
        public string GenreName { get; set; }

        [HasMany(
        Table = "Artist", ColumnKey = "GenreID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Artist> artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public static string[] ReturnAllGenreNames()
        {
            int lid = Genre.Count();

            string[] arr = new string[lid];

            Genre temp = new Genre();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("GenreId") };

            Genre[] allids = (Genre[])Genre.FindAll(typeof(Genre), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Genre)Genre.FindByPrimaryKey(typeof(Genre), allids[i].GenreId);
                arr[counter] = (string)temp.GenreName;
                ++counter;
            }
            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static Genre GetGenreID (string gname)
        {
            ICriterion[] crit = { Expression.Eq("GenreName", gname) };
            Genre t = (Genre)FindFirst(typeof(Genre), crit);
            return t;
        }

        internal static Genre[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }
    }
}
