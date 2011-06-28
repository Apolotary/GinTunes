namespace YPlaylist.BusinessLogic
{
    public class PlayListElems
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string TrackNum { get; set; }
        public string TrackName { get; set; }

        public PlayListElems()
        {

        }

        public PlayListElems(Artist aid, Album alid, TrackList trid)
        {
            ArtistName = (string)aid.ArtistName;
            AlbumName = (string)alid.AlbumName;
            TrackNum = (string)trid.TrackNum;
            TrackName = (string)trid.TrackName;
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
