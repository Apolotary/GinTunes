﻿using System;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;

namespace YPlaylist
{
    public partial class CreatePLControl : UserControl
    {
        public CreatePLControl()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void createPlButton_Click(object sender, EventArgs e)
        {
           try
           {
                string plname = plBox.Text;
                
                if (plname != "")
                {
                    Album tempal = Album.GetAlbumId("TestAlbum");
                    Artist tempar = Artist.CheckArtist("TestBand");
                    TrackList temptr = TrackList.GetTrackId("Test2");

                    PlayList pl = new PlayList(plname, tempal, tempar, temptr);
                    pl.Create();
                }

                MainForm.Instance().ChangeControl(new AddMusicSub());
           }
           catch
           {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
           }
        }
    }
}
