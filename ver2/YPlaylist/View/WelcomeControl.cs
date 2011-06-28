using System;
using System.Windows.Forms;
using YPlaylist.View;

namespace YPlaylist
{
    public partial class WelcomeControl : UserControl
    {
        public WelcomeControl()
        {
            InitializeComponent();
        }

        private void CreatePButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new CreatePLControl());
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new AboutControl());
        }

        private void ManagePButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new ManagePlControl());
        }

        private void MuLibButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new MusicLibControl());
        }

        private void AddMuButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new AddMusicControl());
        }

        private void addGenreLabel_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new GenreLableAdd());
        }
    }
}
