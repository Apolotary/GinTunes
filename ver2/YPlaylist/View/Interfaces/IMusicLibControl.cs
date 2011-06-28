using System.Windows.Forms;
using YPlaylist.BusinessLogic;

namespace YPlaylist.View.Interfaces
{
    interface IMusicLibControl
    {
        PlayListElems[] Pelems { get; set; }
        bool TShow { get; set; }
        DataGridView ContentGrid { get; set; }

        string   GenreAdd  { get; }
        string   LableAdd  { get; }
        string   FormatAdd { get; }
        string   YearAdd   { get; }
        string   ArtistAdd { get; }
        string   AlbumAdd  { get; }

        string[] GenreFBox  { set; }
        string[] LableFBox  { set; }
        string[] FormatFBox { set; }
        string[] YearFBox   { set; }
        string[] ArtistFBox { set; }
        string[] AlbumFBox  { set; }

        void ShowErrorMessage();
        void ShowSuccessMessage();
    }
}
