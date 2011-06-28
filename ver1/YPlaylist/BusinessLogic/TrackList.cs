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
    class TrackList : ActiveRecordBase<TrackList>
    {
        private int TrackID;
        private string TrackName;
        private string TrackNum;
        private Album AlbumID;
        private IList<PlayList> PlayList = new List<PlayList>();

        public TrackList()
        {
        }

        public TrackList(string tl, string tn, Album alid)
        {
            this.TrackName = tl;
            this.TrackNum = tn;
            this.AlbumID = alid;
        }

        [PrimaryKey]
        public int trackID
        {
            get { return TrackID; }
            set { TrackID = value; }
        }

        [Property]
        public string trackName
        {
            get { return TrackName; }
            set { TrackName = value; }
        }

        [Property]
        public string trackNum
        {
            get { return TrackNum; }
            set { TrackNum = value; }
        }

        [BelongsTo("AlbumID")]
        public Album albumID
        {
            get { return AlbumID; }
            set { AlbumID = value; }
        }

        [HasMany(
        Table = "PlayList", ColumnKey = "TrackID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> playList
        {
            get { return PlayList; }
            set { PlayList = value; }
        }

        public static TrackList GetTrackID(string trname)
        {
            ICriterion[] crit = { Expression.Eq("trackName", trname) };
            TrackList t = (TrackList)FindFirst(typeof(TrackList), crit);
            return t;
        }

        public static TrackList GetAlbumName(TrackList trid)
        {
            return FindByPrimaryKey(trid.TrackID);
        }

        public static TrackList[] AddTracks(TrackList[] oltrl, TrackList[] ntrl)
        {
            TrackList[] temp = new TrackList[oltrl.Length + ntrl.Length];
            int counter = 0;
            for (int i = oltrl.Length; i < temp.Length; ++i)
            {
                temp[i] = ntrl[counter];
                ++counter;
            }
            return temp;
        }

        public static PlayListElems[] FillElemsByArtist(Artist artist)
        {
            Album[] tempal = Album.GetAllAlbumID(artist);
            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] trlist = new TrackList[0];
            TrackList[] temp;

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("albumID", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit);
                trlist = TrackList.AddTracks(trlist, temp);
            }

            int pemscount = trlist.Length;
            
            
            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(artist, trlist[i].albumID, trlist[i]);
            }

            return pems;
        }

        public static PlayListElems[] FillElemsByAlbum(Artist artist, Album album)
        {
            Album tempal = album;
            ICriterion[] crit = {Expression.Eq("albumID", tempal)};
            TrackList[] trlist = new TrackList[0];

            trlist = (TrackList[])FindAll(typeof(TrackList), crit);
            int pemscount = trlist.Length;


            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(artist, trlist[i].albumID, trlist[i]);
            }

            return pems;
        }
    }
}
