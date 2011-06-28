using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class Artist : ActiveRecordBase<Artist>
    {
        private int _artistId;
        private IList<Album> _album = new List<Album>();
        private IList<PlayList> _playList = new List<PlayList>();

        public Artist()
        {
        }

        public Artist(string arn, Genre gid)
        {
            this.ArtistName = arn;
            this.GenreId = gid;
        }

        [PrimaryKey]
        public int ArtistId
        {
            get { return _artistId; }
            set { _artistId = value; }
        }

        [Property]
        public string ArtistName { get; set; }

        [HasMany(
        Table = "Album", ColumnKey = "ArtistID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> Album
        {
            get { return _album; }
            set { _album = value; }
        }

        [HasMany(
        Table = "PlayList", ColumnKey = "ArtistID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> PlayList
        {
            get { return _playList; }
            set { _playList = value; }
        }

        [BelongsTo("GenreID")]
        public Genre GenreId { get; set; }

        public static Artist CheckArtist(string aname)
        {
            ICriterion[] crit = { Expression.Eq("ArtistName", aname) };
            Artist t = (Artist)FindFirst(typeof(Artist), crit);
            return t;
        }

        public static Artist[] GetAllArtistsInThisGenre(Genre gid)
        {
            ICriterion[] crit = { Expression.Eq("GenreId", gid) };
            Artist[] t = (Artist[])FindAll(typeof(Artist), crit);
            return t;
        }

        public static string[] ReturnAllArtistNames()
        {
            int lid = Artist.Count();

            string[] arr = new string[lid];

            Artist temp = new Artist();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("ArtistId") };

            Artist[] allids = (Artist[])Artist.FindAll(typeof(Artist), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Artist)Artist.FindByPrimaryKey(typeof(Artist), allids[i].ArtistId);
                arr[counter] = (string)temp.ArtistName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        
        public static Artist GetArtistName(Artist arid)
        {
            return FindByPrimaryKey(arid._artistId);
        }

    }
}
