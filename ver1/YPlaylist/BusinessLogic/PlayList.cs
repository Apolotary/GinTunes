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
    class PlayList : ActiveRecordBase<PlayList>
    {
        private int PlayListID;
        private string PlayListName;
        private Album AlbumID;
        private Artist ArtistID;
        private TrackList TrackID;

        public PlayList()
        {
        }

        public PlayList(string pln, Album alid, Artist aid, TrackList tid)
        {
            this.PlayListName = pln;
            this.ArtistID = aid;
            this.AlbumID = alid;
            this.TrackID = tid;
        }

        [PrimaryKey]
        public int playlistID
        {
            get { return PlayListID; }
            set { PlayListID = value; }
        }

        [Property]
        public string playlistName
        {
            get { return PlayListName; }
            set { PlayListName = value; }
        }

        [BelongsTo("AlbumID")]
        public Album albumID
        {
            get { return AlbumID; }
            set { AlbumID = value; }
        }

        [BelongsTo("ArtistID")]
        public Artist artistID
        {
            get { return ArtistID; }
            set { ArtistID = value; }
        }

        [BelongsTo("TrackID")]
        public TrackList trackID
        {
            get { return TrackID; }
            set { TrackID = value; }
        }

        public static string[] ReturnAllPlayListNames()
        {
            int lid = PlayList.Count();

            string[] arr = new string[lid];

            PlayList temp = new PlayList();
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("playlistID") };

            PlayList[] allids = (PlayList[])PlayList.FindAll(typeof(PlayList), crit);


            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (PlayList)PlayList.FindByPrimaryKey(typeof(PlayList), allids[i].playlistID);
                arr[counter] = (string)temp.PlayListName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static PlayList GetPlayListID(string plname)
        {
            ICriterion[] crit = { Expression.Eq("playlistName", plname) };
            PlayList t = (PlayList)FindFirst(typeof(PlayList), crit);
            return t;
        }

        public static PlayList[] GetAllPlayListID(string plname)
        {
            ICriterion[] crit = { Expression.Eq("playlistName", plname) };
            PlayList[] t = (PlayList[])FindAll(typeof(PlayList), crit);
            return t;
        }

        public static PlayList GetPlayListIDviaTrack(TrackList trid)
        {
            ICriterion[] crit = { Expression.Eq("trackID", trid) };
            PlayList t = (PlayList)FindFirst(typeof(PlayList), crit);
            return t;
        }

        public static PlayListElems[] FillElems(string plname)
        {
            ICriterion[] crit = { Expression.Eq("playlistName", plname) };
            PlayList[] t = (PlayList[])FindAll(typeof(PlayList), crit);

            int pemscount = t.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(t[i].artistID, t[i].albumID, t[i].trackID);
            }

            return pems;
        }
    }
}
