namespace YPlaylist.View.Interfaces
{
    interface IGenreLableAdd
    {
        string GenreAdd  { get; }
        string LableAdd  { get; }
        string FormatAdd { get; }
        string YearAdd   { get; }

        string GenreRem  { get; }
        string LableRem  { get; }
        string FormatRem { get; }
        string YearRem   { get; }

        string[] GenreBox  { set; }
        string[] LableBox  { set; }
        string[] FormatBox { set; }
        string[] YearBox   { set; }

        void ShowErrorMessage();
        void ShowSuccessMessage();
    }
}
