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
    class Album : ActiveRecordBase<Album>
    {
        private int AlbumID;
        private string AlbumName;
        private IList<TrackList> Track = new List<TrackList>();
        private IList<PlayList> PList = new List<PlayList>();
        private Artist ArtistID;
        private YearTable YearID;
        private Lable LableID;
        private AlbumFormat FormatID;

        public Album()
        {
        }

        public Album(string an, Artist ar, YearTable yr, Lable la, AlbumFormat af)
        {
            this.AlbumName = an;
            this.ArtistID = ar;
            this.YearID = yr;
            this.LableID = la;
            this.FormatID = af;
        }

        [PrimaryKey]
        public int albumID
        {
            get { return AlbumID; }
            set { AlbumID = value; }
        }

        [Property]
        public string albumName
        {
            get { return AlbumName; }
            set { AlbumName = value; }
        }

        [BelongsTo("ArtistID")]
        public Artist artistID
        {
            get { return ArtistID; }
            set { ArtistID = value; }
        }

        [BelongsTo("YearID")]
        public YearTable yearID
        {
            get { return YearID; }
            set { YearID = value; }
        }
        [BelongsTo("LableID")]
        public Lable lableID
        {
            get { return LableID; }
            set { LableID = value; }
        }
        [BelongsTo("FormatID")]
        public AlbumFormat formatID
        {
            get { return FormatID; }
            set { FormatID = value; }
        }

        [HasMany(
        Table = "TrackList", ColumnKey = "AlbumID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<TrackList> track
        {
            get { return Track; }
            set { Track = value; }
        }

        [HasMany(
        Table = "PlayList", ColumnKey = "AlbumID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> plist
        {
            get { return PList; }
            set { PList = value; }
        }

        public static Album GetAlbumID(string alname)
        {
            ICriterion[] crit = { Expression.Eq("albumName", alname) };
            Album t = (Album)FindFirst(typeof(Album), crit);
            return t;
        }

        public static Album[] GetAllAlbumID(Artist ar)
        {
            ICriterion[] crit = { Expression.Eq("artistID", ar) };
            Album[] t = (Album[])FindAll(typeof(Album), crit);
            return t;
        }

        public static Album GetAlbumName(Album alid)
        {
            return FindByPrimaryKey(alid.AlbumID);
        }

        public static string[] ReturnAllAlbumNames()
        {
            int lid = Album.Count();

            string[] arr = new string[lid];

            Album temp = new Album();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("albumID") };

            Album[] allids = (Album[])Album.FindAll(typeof(Album), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (Album)Album.FindByPrimaryKey(typeof(Album), allids[i].albumID);
                arr[counter] = (string)temp.albumName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static string[] ReturnAllAlbumNamesByArtist(Artist ar)
        {
            
            Album[] temp = Album.GetAllAlbumID(ar);
            int counter = 0;

            int lid = temp.Length;

            string[] arr = new string[lid];
            
            for (int i = 0; i < lid; ++i)
            {
                
                arr[counter] = (string)temp[i].albumName;
                ++counter;
            }

            return arr;
        }
    }
}
