using System;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;

namespace YPlaylist
{
    public partial class ManagePlControl : UserControl
    {
        PlayListElems[] _pelems;
        bool _show = false;
        public ManagePlControl()
        {
            InitializeComponent();
            PlaylistBox.DataSource = PlayList.ReturnAllPlayListNames();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void addMusToPlButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new AddMusicSub());
        }

        private void removeFromPlButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string plname = PlaylistBox.Text;
                _pelems = PlayList.FillElems(plname);

                plContentGrid.DataSource = _pelems;
                Invalidate();

                _show = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_show)
                {
                    string plName = PlaylistBox.Text;


                    PlayList[] pl = PlayList.GetAllPlayListID(plName);

                    for (int i = 0; i < pl.Length; ++i)
                    {
                        pl[i].Delete();
                    }
                    MessageBox.Show("Done!^_^", "TheResult");
                }
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
            
        }
    }
}
