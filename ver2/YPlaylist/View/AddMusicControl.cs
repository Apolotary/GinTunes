using System;
using System.Windows.Forms;
using YPlaylist.Presenter;
using YPlaylist.View.Interfaces;

namespace YPlaylist
{
    public partial class AddMusicControl : UserControl, IAddMusicControl
    {
        #region Add Properties
        public string ArtistAdd
        {
            get { return artistTBox.Text; }
        }

        public string LableAdd
        {
            get { return lableBox.Text; }
        }

        public string FormatAdd
        {
            get { return formatBox.Text; }
        }

        public string YearAdd
        {
            get { return yearBox.Text; }
        }

        public string GenreAdd
        {
            get { return genreBox.Text; }
        }

        public string AlbumAdd
        {
            get { return albumTBox.Text; }
        }

        public string[] TrackListAdd
        {
            get { return tracklistTBox.Lines; }
        }
        #endregion

        #region Fill Properties
        public string[] GenreBox
        {
            set { genreBox.DataSource = value; }
        }

        public string[] LableBox
        {
            set { lableBox.DataSource = value; }
        }

        public string[] FormatBox
        {
            set { formatBox.DataSource = value; }
        }

        public string[] YearBox
        {
            set { yearBox.DataSource = value; }
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

        private readonly AddMusicControlP _addMusicControlPresenter;
        public AddMusicControl()
        {
            InitializeComponent();
            _addMusicControlPresenter = new AddMusicControlP(this);
            _addMusicControlPresenter.FillBox();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new GenreLableAdd());
        }

        // add artist and album
        private void addButton_Click(object sender, EventArgs e)
        {
            _addMusicControlPresenter.AddButtClick();
        }

        private void AddByArtist_Click(object sender, EventArgs e)
        {
            _addMusicControlPresenter.AddByArtistClick();
        }

    }
}
