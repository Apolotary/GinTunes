using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class PlayList : ActiveRecordBase<PlayList>
    {
        public PlayList()
        {
        }

        public PlayList(string pln, Album alid, Artist aid, TrackList tid)
        {
            this.PlaylistName = pln;
            this.ArtistId = aid;
            this.AlbumId = alid;
            this.TrackId = tid;
        }

        [PrimaryKey]
        public int PlaylistId { get; set; }

        [Property]
        public string PlaylistName { get; set; }

        [BelongsTo("AlbumID")]
        public Album AlbumId { get; set; }

        [BelongsTo("ArtistID")]
        public Artist ArtistId { get; set; }

        [BelongsTo("TrackID")]
        public TrackList TrackId { get; set; }

        public static string[] ReturnAllPlayListNames()
        {
            int lid = PlayList.Count();

            string[] arr = new string[lid];

            PlayList temp;
            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("PlaylistId") };

            PlayList[] allids = (PlayList[])PlayList.FindAll(typeof(PlayList), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (PlayList)PlayList.FindByPrimaryKey(typeof(PlayList), allids[i].PlaylistId);
                arr[counter] = (string)temp.PlaylistName;
                ++counter;
            }
            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static PlayList GetPlayListID(string plname)
        {
            ICriterion[] crit = { Expression.Eq("PlaylistName", plname) };
            PlayList t = (PlayList)FindFirst(typeof(PlayList), crit);
            return t;
        }

        public static PlayList[] GetAllPlayListID(string plname)
        {
            ICriterion[] crit = { Expression.Eq("PlaylistName", plname) };
            PlayList[] t = (PlayList[])FindAll(typeof(PlayList), crit);
            return t;
        }

        public static PlayList GetPlayListIDviaTrack(TrackList trid)
        {
            ICriterion[] crit = { Expression.Eq("TrackId", trid) };
            PlayList t = (PlayList)FindFirst(typeof(PlayList), crit);
            return t;
        }

        public static PlayListElems[] FillElems(string plname)
        {
            ICriterion[] crit = { Expression.Eq("PlaylistName", plname) };
            PlayList[] t = (PlayList[])FindAll(typeof(PlayList), crit);

            int pemscount = t.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(t[i].ArtistId, t[i].AlbumId, t[i].TrackId);
            }

            return pems;
        }
    }
}
