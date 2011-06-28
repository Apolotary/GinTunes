using YPlaylist.BusinessLogic;


namespace YPlaylist.Presenter
{
    class ReturnData
    {
        //retrieves specified data from model
        public ReturnData()
        {
        }

        public static string[] Retgen()
        {
            return Genre.ReturnAllGenreNames();
        }
        public static string[] Retlabel()
        {
            return Lable.ReturnAllLableNames();
        }
        public static string[] Retformat()
        {
            return AlbumFormat.ReturnAllFormatNames();
        }
        public static string[] Retyears()
        {
            return YearTable.ReturnAllYearNames();
        }
        public static string[] Retartists()
        {
            return Artist.ReturnAllArtistNames();
        }
        public static string[] Retalbums(Artist ar)
        {
            return Album.ReturnAllAlbumNamesByArtist(ar);
        }
    }
}
