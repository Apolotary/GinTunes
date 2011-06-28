using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using Castle.Components;
using System.Linq;
using System.Text;
using Castle.ActiveRecord.Queries;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    class Genre : ActiveRecordBase<Genre>
    {
        private int GenreID;
        private string GenreName;
        private IList<Artist> Artist = new List<Artist>();


        public Genre()
        {
        }

        public Genre(string gName)
        {
            this.GenreName = gName;
        }

        [PrimaryKey]
        private int genreID
        {
            get { return GenreID; }
            set { GenreID = value; }
        }

        [Property]
        public string genreName
        {
            get { return GenreName; }
            set { GenreName = value; }
        }

        [HasMany(
        Table = "Artist", ColumnKey = "GenreID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Artist> artist
        {
            get { return Artist; }
            set { Artist = value; }
        }

        public static string[] ReturnAllGenreNames()
        {
            int lid = Genre.Count();

            string[] arr = new string[lid];

            Genre temp = new Genre();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("genreID") };

            Genre[] allids = (Genre[])Genre.FindAll(typeof(Genre), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Genre)Genre.FindByPrimaryKey(typeof(Genre), allids[i].genreID);
                arr[counter] = (string)temp.genreName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static Genre GetGenreID (string gname)
        {
            ICriterion[] crit = {Expression.Eq("genreName", gname)};
            Genre t = (Genre)FindFirst(typeof(Genre), crit);
            return t;
        }

        internal static Genre[] ExecuteQuery()
        {
            throw new NotImplementedException();
        }

    }
}
