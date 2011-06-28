using System;
using System.Windows.Forms;
using YPlaylist.Presenter;
using YPlaylist.View.Interfaces;

namespace YPlaylist
{
    public partial class GenreLableAdd : UserControl, IGenreLableAdd
    {
     // Properties
        #region ToAdd
        public string GenreAdd
        {
            get { return genreTBox.Text; }
        }

        public string LableAdd
        {
            get { return lableBox.Text; }
        }

        public string FormatAdd
        {
            get { return formatTBox.Text; }
        }

        public string YearAdd
        {
            get { return yearBox.Text; }
        }
        #endregion
        #region ToRemove
        public string GenreRem
        {
            get { return genreCombo.Text; }
        }

        public string LableRem
        {
            get { return labelCombo.Text; }
        }

        public string FormatRem
        {
            get { return formatCombo.Text; }
        }

        public string YearRem
        {
            get { return yearCombo.Text; }
        }
        #endregion
        #region ToFill
        public string[] GenreBox
        {
            set { genreCombo.DataSource = value; }
        }

        public string[] LableBox
        {
            set { labelCombo.DataSource = value; }
        }

        public string[] FormatBox
        {
            set { formatCombo.DataSource = value; }
        }

        public string[] YearBox
        {
            set { yearCombo.DataSource = value; }
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

        private readonly GenreLableAddP _genreLableAddPresenter;
        public GenreLableAdd()
        {
            InitializeComponent();
            _genreLableAddPresenter = new GenreLableAddP(this);
            _genreLableAddPresenter.FillBoxes();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        #region Add Buttons
        private void addLabelButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.AddLableClick();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.AddGenreClick();
        }

        private void addFormatButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.AddFormatClick();
        }

        private void addYear_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.AddYearClick();
        }
        #endregion

        #region Remove Buttons
        private void remGenreButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.RemGenreClick();
        }

        private void remLabelButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.RemLableClick();
        }

        private void remFormatButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.RemFormatClick();
        }

        private void remYearButton_Click(object sender, EventArgs e)
        {
            _genreLableAddPresenter.RemYearClick();
        }
        #endregion
    }
}
