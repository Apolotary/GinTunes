using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class Album : ActiveRecordBase<Album>
    {
        private int _albumId;
        private IList<TrackList> _track = new List<TrackList>();
        private IList<PlayList> _pList = new List<PlayList>();

        public Album()
        {
        }

        public Album(string an, Artist ar, YearTable yr, Lable la, AlbumFormat af)
        {
            this.AlbumName = an;
            this.ArtistId = ar;
            this.YearId = yr;
            this.LableId = la;
            this.FormatId = af;
        }

        [PrimaryKey]
        public int AlbumId
        {
            get { return _albumId; }
            set { _albumId = value; }
        }

        [Property]
        public string AlbumName { get; set; }

        [BelongsTo("ArtistID")]
        public Artist ArtistId { get; set; }

        [BelongsTo("YearID")]
        public YearTable YearId { get; set; }

        [BelongsTo("LableID")]
        public Lable LableId { get; set; }

        [BelongsTo("FormatID")]
        public AlbumFormat FormatId { get; set; }

        [HasMany(
        Table = "TrackList", ColumnKey = "AlbumID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<TrackList> Track
        {
            get { return _track; }
            set { _track = value; }
        }

        [HasMany(
        Table = "PlayList", ColumnKey = "AlbumID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> Plist
        {
            get { return _pList; }
            set { _pList = value; }
        }

        public static Album GetAlbumId(string alname)
        {
            ICriterion[] crit = { Expression.Eq("AlbumName", alname) };
            Album t = (Album)FindFirst(typeof(Album), crit);
            return t;
        }

        public static Album[] GetAllAlbumId(Artist ar)
        {
            ICriterion[] crit = { Expression.Eq("ArtistId", ar) };
            Album[] t = (Album[])FindAll(typeof(Album), crit);
            return t;
        }

        public static Album[] GetAllAlbumIDbyYear(YearTable yr)
        {
            ICriterion[] crit = { Expression.Eq("YearId", yr) };
            Album[] t = (Album[])FindAll(typeof(Album), crit);
            return t;
        }

        public static Album[] GetAllAlbumIDbyLabel(Lable yr)
        {
            ICriterion[] crit = { Expression.Eq("LableId", yr) };
            Album[] t = (Album[])FindAll(typeof(Album), crit);
            return t;
        }

        public static Album[] GetAllAlbumIDbyFormat(AlbumFormat yr)
        {
            ICriterion[] crit = { Expression.Eq("FormatId", yr) };
            Album[] t = (Album[])FindAll(typeof(Album), crit);
            return t;
        }

        public static Album[] Refill (Album[] ol, Album[] newal)
        {
            Album[] temp = new Album[ol.Length + newal.Length];
            for (int i = 0; i < ol.Length; ++i)
            {
                temp[i] = ol[i];
            }
            int counter = 0;
            for (int i = ol.Length; i < temp.Length; ++i)
            {
                temp[i] = newal[counter];
                ++counter;
            }

            return temp;
        }

        public static Artist GetArtistIDFromAlbum(Album al)
        {
            ICriterion[] crit = { Expression.Eq("ArtistId", al.ArtistId.ArtistId) };
            Artist t = (Artist)FindFirst(typeof(Artist), crit);
            return t;
        }

        public static Album GetAlbumName(Album alid)
        {
            return FindByPrimaryKey(alid._albumId);
        }

        public static string[] ReturnAllAlbumNames()
        {
            int lid = Album.Count();

            string[] arr = new string[lid];

            Album temp = new Album();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("AlbumId") };

            Album[] allids = (Album[])Album.FindAll(typeof(Album), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Album)Album.FindByPrimaryKey(typeof(Album), allids[i].AlbumId);
                arr[counter] = (string)temp.AlbumName;
                ++counter;
            }
            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static string[] ReturnAllAlbumNamesByArtist(Artist ar)
        {
            
            Album[] temp = Album.GetAllAlbumId(ar);
            int counter = 0;

            int lid = temp.Length;

            string[] arr = new string[lid];
            
            for (int i = 0; i < lid; ++i)
            {
                
                arr[counter] = (string)temp[i].AlbumName;
                ++counter;
            }
            return arr;
        }
    }
}
