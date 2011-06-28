namespace YPlaylist.View.Interfaces
{
    interface IAddMusicControl
    {
        string   ArtistAdd { get; }
        string   LableAdd  { get; }
        string   FormatAdd { get; }
        string   YearAdd   { get; }
        string   GenreAdd  { get; }
        string   AlbumAdd  { get; }
        string[] TrackListAdd { get; }

        string[] GenreBox { set; }
        string[] LableBox { set; }
        string[] FormatBox { set; }
        string[] YearBox { set; }

        void ShowErrorMessage();
        void ShowSuccessMessage();
    }
}
