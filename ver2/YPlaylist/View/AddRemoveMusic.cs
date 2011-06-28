using System;
using System.Windows.Forms;

namespace YPlaylist
{
    public partial class AddRemoveMusic : UserControl
    {
        public AddRemoveMusic()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }
    }
}
