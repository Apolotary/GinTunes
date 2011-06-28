using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;

namespace YPlaylist
{
    public partial class MusicLibControl : UserControl
    {
        PlayListElems[] pelems;
        bool show = false; 

        public MusicLibControl()
        {
            InitializeComponent();
            artistBox.DataSource = Artist.ReturnAllArtistNames();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string artistN = artistBox.Text;
                string albumN = albumBox.Text;

                if (albumN == "")
                {
                    Artist ar = Artist.CheckArtist(artistN);
                    pelems = TrackList.FillElemsByArtist(ar);

                    plContentGrid.DataSource = pelems;
                    Invalidate();
                }
                else
                {
                    Artist ar = Artist.CheckArtist(artistN);
                    Album al = Album.GetAlbumID(albumN);
                    pelems = TrackList.FillElemsByAlbum(ar, al);

                    plContentGrid.DataSource = pelems;
                    Invalidate();
                }
                show = true;
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void artistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string artistN = artistBox.Text;
                Artist ar = Artist.CheckArtist(artistN);

                albumBox.DataSource = Album.ReturnAllAlbumNamesByArtist(ar);

            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void remTracks_Click(object sender, EventArgs e)
        {
            try
            {
                if (show)
                {
                    Int32 selectedRowCount =
                plContentGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    int[] row = new int[selectedRowCount];
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        row[i] = plContentGrid.SelectedRows[i].Index;
                    }
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        TrackList trtemp = TrackList.GetTrackID(pelems[row[i]].TrackName);
                        trtemp.Delete();
                    }
                    MessageBox.Show("Done!^_^", "TheResult");
                }
                
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void remArtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (show)
                {
                    string arName = artistBox.Text;
                    
                    Artist ar = Artist.CheckArtist(arName);

                    ar.Delete();
                    MessageBox.Show("Done!^_^", "TheResult");
                }
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void remAlbButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (show)
                {
                    string alName = albumBox.Text;

                    Album al = Album.GetAlbumID(alName);

                    al.Delete();
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
