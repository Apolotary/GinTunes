using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;
using System.Web;

namespace YPlaylist
{
    public partial class AddMusicSub : UserControl
    {
        PlayListElems[] pelems;
        bool show = true; // true - playlist content is showed, false - artist|album content

        public AddMusicSub()
        {
            InitializeComponent();
            PlBox.DataSource = PlayList.ReturnAllPlayListNames();
            artistBox.DataSource = Artist.ReturnAllArtistNames();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void loadPLButton_Click(object sender, EventArgs e)
        {
            try
            {
                string plname = PlBox.Text;
                pelems = PlayList.FillElems(plname);

                plContentGrid.DataSource = pelems;
                Invalidate();

                show = true;
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
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
                show = false;
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

        private void addToPlButton_Click(object sender, EventArgs e)
        {
            try
            {
                string plName = PlBox.Text;
                Int32 selectedRowCount =
            plContentGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

                int[] row = new int[selectedRowCount];
                for (int i = 0; i < selectedRowCount; ++i)
                {
                    row[i] = plContentGrid.SelectedRows[i].Index;
                }
                PlayList pl;
                for (int i = 0; i < selectedRowCount; ++i)
                {
                    pl = new PlayList(plName, Album.GetAlbumID(pelems[row[i]].AlbumName),
                                        Artist.CheckArtist(pelems[row[i]].ArtistName),
                                        TrackList.GetTrackID(pelems[row[i]].TrackName));
                    pl.Create();
                }
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void plContentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plContentGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void remFromPlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (show)
                {
                    string plName = PlBox.Text;
                    Int32 selectedRowCount =
                plContentGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    int[] row = new int[selectedRowCount];
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        row[i] = plContentGrid.SelectedRows[i].Index;
                    }
                    PlayList pl;
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        TrackList trtemp = TrackList.GetTrackID(pelems[row[i]].TrackName);
                        pl = PlayList.GetPlayListIDviaTrack(trtemp);
                        pl.Delete();
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
