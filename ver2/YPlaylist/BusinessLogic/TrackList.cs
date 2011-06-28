using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class TrackList : ActiveRecordBase<TrackList>
    {
        private IList<PlayList> _playList = new List<PlayList>();

        public TrackList()
        {
        }

        public TrackList(string tl, string tn, Album alid)
        {
            this.TrackName = tl;
            this.TrackNum = tn;
            this.AlbumId = alid;
        }

        [PrimaryKey]
        public int TrackId { get; set; }

        [Property]
        public string TrackName { get; set; }

        [Property]
        public string TrackNum { get; set; }

        [BelongsTo("AlbumID")]
        public Album AlbumId { get; set; }

        [HasMany(
        Table = "PlayList", ColumnKey = "TrackID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<PlayList> PlayList
        {
            get { return _playList; }
            set { _playList = value; }
        }

        public static TrackList GetTrackId(string trname)
        {
            ICriterion[] crit = { Expression.Eq("TrackName", trname) };
            TrackList t = (TrackList)FindFirst(typeof(TrackList), crit);
            return t;
        }

        public static TrackList GetAlbumName(TrackList trid)
        {
            return FindByPrimaryKey(trid.TrackId);
        }

        public static TrackList[] AddTracks(TrackList[] oltrl, TrackList[] ntrl)
        {
            TrackList[] temp = new TrackList[oltrl.Length + ntrl.Length];
            int counter = 0;
            for (int i = 0; i < oltrl.Length; ++i)
            {
                temp[i] = oltrl[i];
            }
            for (int i = oltrl.Length; i < temp.Length; ++i)
            {
                temp[i] = ntrl[counter];
                ++counter;
            }
            return temp;
        }

        public static PlayListElems[] FillElemsByArtist(Artist artist)
        {
            Album[] tempal = Album.GetAllAlbumId(artist);
            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] trlist = new TrackList[0];
            TrackList[] temp;

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("AlbumId", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit[i]);
                trlist = TrackList.AddTracks(trlist, temp);
            }

            int pemscount = trlist.Length;
            
            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(artist, trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }

        public static PlayListElems[] FillElemsByAlbum(Artist artist, Album album)
        {
            Album tempal = album;
            ICriterion[] crit = {Expression.Eq("AlbumId", tempal)};
            TrackList[] trlist = new TrackList[0];

            trlist = (TrackList[])FindAll(typeof(TrackList), crit);
            int pemscount = trlist.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(artist, trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }

        public static PlayListElems[] FillElemsByYear(YearTable year)
        {
            Album[] tempal = Album.GetAllAlbumIDbyYear(year) ;
            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] temp;
            TrackList[] trlist = new TrackList[0];

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("AlbumId", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit[i]);
                trlist = TrackList.AddTracks(trlist, temp);
            }
            int pemscount = trlist.Length;
                       
            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(Album.GetArtistIDFromAlbum(trlist[i].AlbumId), trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }

        public static PlayListElems[] FillElemsByLabel(Lable lab)
        {
            Album[] tempal = Album.GetAllAlbumIDbyLabel(lab);
            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] temp;
            TrackList[] trlist = new TrackList[0];

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("AlbumId", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit[i]);
                trlist = TrackList.AddTracks(trlist, temp);
            }
            int pemscount = trlist.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(Album.GetArtistIDFromAlbum(trlist[i].AlbumId), trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }

        public static PlayListElems[] FillElemsByFormat(AlbumFormat form)
        {
            Album[] tempal = Album.GetAllAlbumIDbyFormat(form);
            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] temp;
            TrackList[] trlist = new TrackList[0];

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("AlbumId", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit[i]);
                trlist = TrackList.AddTracks(trlist, temp);
            }
            int pemscount = trlist.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(Album.GetArtistIDFromAlbum(trlist[i].AlbumId), trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }

        
        public static PlayListElems[] FillElemsByGenre(Genre gen)
        {
            Artist[] tempar = Artist.GetAllArtistsInThisGenre(gen);
            
            Album[] tempal = new Album[0];
            Album[] temptemp;
            Album[] t3;
            for (int i = 0; i < tempar.Length; ++i)
            {
                temptemp = Album.GetAllAlbumId(tempar[i]);
                t3 = tempal;
                tempal = Album.Refill(t3, temptemp);
            }

            ICriterion[] crit = new ICriterion[tempal.Length];
            TrackList[] temp;
            TrackList[] trlist = new TrackList[0];

            for (int i = 0; i < crit.Length; ++i)
            {
                crit[i] = Expression.Eq("AlbumId", tempal[i]);
                temp = (TrackList[])FindAll(typeof(TrackList), crit[i]);
                trlist = TrackList.AddTracks(trlist, temp);
            }
            
            int pemscount = trlist.Length;

            PlayListElems[] pems = new PlayListElems[pemscount];

            for (int i = 0; i < pemscount; ++i)
            {
                pems[i] = new PlayListElems(Album.GetArtistIDFromAlbum(trlist[i].AlbumId), trlist[i].AlbumId, trlist[i]);
            }

            return pems;
        }
    }
}
