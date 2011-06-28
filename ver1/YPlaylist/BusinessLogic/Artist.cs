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
    class Artist : ActiveRecordBase<Artist>
    {
        private int ArtistID;
        private string ArtistName;
        private Genre GenreID;
        private IList<Album> Album = new List<Album>();
        private IList<PlayList> PlayList = new List<PlayList>();

        public Artist()
        {
        }

        public Artist(string arn, Genre gid)
        {
            this.ArtistName = arn;
            this.GenreID = gid;
        }

        [PrimaryKey]
        public int artistID
        {
            get { return ArtistID; }
            set { ArtistID = value; }
        }

        [Property]
        public string artistName
        {
            get { return ArtistName; }
            set { ArtistName = value; }
        }

        [HasMany(
        Table = "Album", ColumnKey = "ArtistID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> album
        {
            get { return Album; }
            set { Album = value; }
        }

        [HasMany(
        Table = "PlayList", ColumnKey = "ArtistID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> playList
        {
            get { return PlayList; }
            set { PlayList = value; }
        }

        [BelongsTo("GenreID")]
        public Genre genreID
        {
            get { return GenreID; }
            set { GenreID = value; }
        }

        public static Artist CheckArtist(string aname)
        {
            ICriterion[] crit = { Expression.Eq("artistName", aname) };
            Artist t = (Artist)FindFirst(typeof(Artist), crit);
            return t;
        }

        public static string[] ReturnAllArtistNames()
        {
            int lid = Artist.Count();

            string[] arr = new string[lid];

            Artist temp = new Artist();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("artistID") };

            Artist[] allids = (Artist[])Artist.FindAll(typeof(Artist), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Artist)Artist.FindByPrimaryKey(typeof(Artist), allids[i].artistID);
                arr[counter] = (string)temp.artistName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static Artist GetArtistName(Artist arid)
        {
            return FindByPrimaryKey(arid.ArtistID);
        }

    }
}
