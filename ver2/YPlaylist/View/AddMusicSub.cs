using System;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;

namespace YPlaylist
{
    public partial class AddMusicSub : UserControl
    {
        PlayListElems[] _pelems;
        bool _show = true; // true - playlist content is showed, false - artist|album content

        public AddMusicSub()
        {
            InitializeComponent();
            PlBox.DataSource = PlayList.ReturnAllPlayListNames();
            artistBox.DataSource = Artist.ReturnAllArtistNames();
            labelBox.DataSource = Lable.ReturnAllLableNames();
            genreBox.DataSource = Genre.ReturnAllGenreNames();
            yearBox.DataSource = YearTable.ReturnAllYearNames();
            formatBox.DataSource = AlbumFormat.ReturnAllFormatNames();
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
                _pelems = PlayList.FillElems(plname);

                plContentGrid.DataSource = _pelems;
                Invalidate();

                _show = true;
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
                    _pelems = TrackList.FillElemsByArtist(ar);

                    plContentGrid.DataSource = _pelems;
                    Invalidate();
                }
                else
                {
                    Artist ar = Artist.CheckArtist(artistN);
                    Album al = Album.GetAlbumId(albumN);
                    _pelems = TrackList.FillElemsByAlbum(ar, al);

                    plContentGrid.DataSource = _pelems;
                    Invalidate();
                }
                _show = false;
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
                    pl = new PlayList(plName, Album.GetAlbumId(_pelems[row[i]].AlbumName),
                                        Artist.CheckArtist(_pelems[row[i]].ArtistName),
                                        TrackList.GetTrackId(_pelems[row[i]].TrackName));
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
                if (_show)
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
                        TrackList trtemp = TrackList.GetTrackId(_pelems[row[i]].TrackName);
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

        private void yearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string year = yearBox.Text;
                YearTable yr = YearTable.GetYearID(year);
                _pelems = TrackList.FillElemsByYear(yr);

                plContentGrid.DataSource = _pelems;
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void genreSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string genren = genreBox.Text;
                Genre ge = Genre.GetGenreID(genren);
                _pelems = TrackList.FillElemsByGenre(ge);

                plContentGrid.DataSource = _pelems;
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string labeln = labelBox.Text;
                Lable lb = Lable.GetLableId(labeln);
                _pelems = TrackList.FillElemsByLabel(lb);

                plContentGrid.DataSource = _pelems;
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }

        private void formatSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string format = formatBox.Text;
                AlbumFormat af = AlbumFormat.GetFormatId(format);
                _pelems = TrackList.FillElemsByFormat(af);

                plContentGrid.DataSource = _pelems;
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Something bad has happened =(", "Whoops!");
            }
        }
    }
}
