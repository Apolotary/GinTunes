using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using Castle.Components;
using System.Linq;
using System.Text;
using Castle.ActiveRecord.Queries;
using NHibernate;

namespace YPlaylist.BusinessLogic
{
    class PlayListElems
    {
        string artistName;
        string albumName;
        string trackNum;
        string trackName;

        public PlayListElems()
        {

        }
        public PlayListElems(Artist aid, Album alid, TrackList trid)
        {
            artistName = (string)aid.artistName;
            albumName = (string)alid.albumName;
            trackNum = (string)trid.trackNum;
            trackName = (string)trid.trackName;
        }

        public string ArtistName
        {
            get { return artistName; }
            set { artistName = value; }
        }
        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; }
        }
        public string TrackNum
        {
            get { return trackNum; }
            set { trackNum = value; }
        }
        public string TrackName
        {
            get { return trackName; }
            set { trackName = value; }
        }

        
        public static string[] RemoveRepeatedElems(string[] arr)
        {
            bool found = false;
            string[] temp = new string[arr.Length];
            int counter = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                found = false;
                if (i == 0)
                {
                    temp[counter] = arr[i];
                    ++counter;
                }
                else
                {
                    for (int j = 0; j < i; ++j)
                    {
                        if (arr[j] == arr[i])
                        {
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        temp[counter] = arr[i];
                        ++counter;
                        
                    }
                }
            }

            string[] t2 = new string[counter];

            for (int i = 0; i < t2.Length; ++i)
            {
                t2[i] = temp[i];
            }

            return t2;
        }
    }
}
