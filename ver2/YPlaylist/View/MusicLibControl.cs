using System;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;
using YPlaylist.Presenter;
using YPlaylist.View.Interfaces;

namespace YPlaylist.View
{
    public partial class MusicLibControl : UserControl, IMusicLibControl
    {
        PlayListElems[] _pelems;
        bool _show = false;

        #region Pelems, Show and Grid properties

        public PlayListElems[] Pelems
        {
            get { return _pelems; }
            set { _pelems = value; }
        }
        public bool TShow
        {
            get { return _show; } 
            set { _show = value; }
        }
        public DataGridView ContentGrid
        {
            get { return plContentGrid; }
            set { plContentGrid = value; }
        }
        
        #endregion

        #region Add Properties
        public string GenreAdd
        {
            get { return genreBox.Text; }
        }

        public string LableAdd
        {
            get { return labelBox.Text; }
        }

        public string FormatAdd
        {
            get { return formatBox.Text; }
        }

        public string YearAdd
        {
            get { return yearBox.Text; }
        }

        public string ArtistAdd
        {
            get { return artistBox.Text; }
        }

        public string AlbumAdd
        {
            get { return albumBox.Text; }
        }
        #endregion

        #region Fill Properties
        public string[] GenreFBox
        {
            set { genreBox.DataSource = value; }
        }

        public string[] LableFBox
        {
            set { labelBox.DataSource = value; }
        }

        public string[] FormatFBox
        {
            set { formatBox.DataSource = value; }
        }

        public string[] YearFBox
        {
            set { yearBox.DataSource = value; }
        }

        public string[] ArtistFBox
        {
            set { artistBox.DataSource = value; }
        }

        public string[] AlbumFBox
        {
            set { albumBox.DataSource = value; }
        }
        #endregion

        #region Messages
        public void ShowErrorMessage()
        {
            MessageBox.Show("Something bad has happened. Please be careful next time!", "Oh noes!");
        }

        public void ShowSuccessMessage()
        {
            MessageBox.Show("Something was done successfully!", "Yaay!");
        }
        #endregion

        private readonly MusicLibControlP _musicLibPresenter;
        public MusicLibControl()
        {
            InitializeComponent();
            _musicLibPresenter = new MusicLibControlP(this);
            _musicLibPresenter.FillBox();
        }

        private void artistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _musicLibPresenter.FillAlbums();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.searchButtonClick();
        }

        #region Remove Methods
        private void remTracks_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.remTracksClick();
        }

        private void remArtButton_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.RemArtButtonClick();
        }

        private void remAlbButton_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.RemAlbButtonClick();
        }
        #endregion

        #region Search Methods
        private void yearSearch_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.YearSearchClick();
        }

        private void genreSearch_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.GenreSearchClick();
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.GenreLabelClick();
        }

        private void formatSearch_Click(object sender, EventArgs e)
        {
            _musicLibPresenter.GenreFormatClick();
        }
        #endregion
    }
}
