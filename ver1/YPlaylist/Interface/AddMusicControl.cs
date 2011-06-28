using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using YPlaylist.BusinessLogic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPlaylist
{
    public partial class AddMusicControl : UserControl
    {
        public AddMusicControl()
        {
            InitializeComponent();
            genreBox.DataSource = Genre.ReturnAllGenreNames();
            lableBox.DataSource = Lable.ReturnAllLableNames();
            formatBox.DataSource = AlbumFormat.ReturnAllFormatNames();
            yearBox.DataSource = YearTable.ReturnAllYearNames();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new GenreLableAdd());
        }

        private void AddMusicControl_Load(object sender, EventArgs e)
        {

        }

        private void lableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lableBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // add artist and album
        private void addButton_Click(object sender, EventArgs e)
        {
           try 
           {
                string artistName = artistTBox.Text;

                if (artistName == "")
                {
                   Exception ex = new Exception("Please, insert artist's name!");
                   throw ex; 
                }

                string gName = genreBox.Text;
                Genre gID = Genre.GetGenreID(gName);
                Artist findartist = Artist.CheckArtist(artistName);
                

                Artist artist = new Artist();

                if (findartist == null)
                {
                    artist = new Artist(artistName, gID);
                    artist.Create();
                    artist = Artist.CheckArtist(artistName);
                }
                else
                {
                    artist = Artist.CheckArtist(artistName);
                }
                string y = yearBox.Text;

                YearTable year = YearTable.GetYearID(y);


                if (year == null)
                {
                    year = new YearTable(y);
                    year.Create();
                    year = YearTable.GetYearID(y);
                }
                else
                {
                    year = YearTable.GetYearID(y);
                }

                string l = lableBox.Text;
                Lable lable = Lable.GetLableID(l);


                if (lable == null)
                {
                    lable = new Lable(l);
                    lable.Create();
                    lable = Lable.GetLableID(l);
                }
                else
                {
                    lable = Lable.GetLableID(l);
                }

                string af = formatBox.Text;
                AlbumFormat format = AlbumFormat.GetFormatID(af);


                if (format == null)
                {
                    format = new AlbumFormat(af);
                    format.Create();
                    format = AlbumFormat.GetFormatID(af);
                }
                else
                {
                    format = AlbumFormat.GetFormatID(af);
                }
            
                string alname = albumTBox.Text;

                Album album = new Album(alname, artist, year, lable, format);
                album.Create();

                album = Album.GetAlbumID(alname);

                string[] tracklist = tracklistTBox.Lines;

                TrackList tl;

                for (int i = 0; i < tracklist.Length; ++i)
                {
                    string tnum = "00";
                    string tname = "";
                    string tempp = "";
                    bool whitespace = false;
                    for (int j = 0; j < tracklist[i].Length; ++j)
                    {
                        if (tracklist[i][j] == ' ' && !whitespace)
                        {
                            whitespace = true;
                            tnum = tempp;
                            tempp = "";
                        }
                        else
                        {
                            tempp += tracklist[i][j];
                        }
                    }
                    tname = tempp;
                    tl = new TrackList(tname, tnum, album);
                    tl.Create();
                }

                MessageBox.Show("Done!^_^", "TheResult");
          }
          catch
          {
             MessageBox.Show("Something bad has happened!", "Whoops!");
          }
        }

        private void AddByArtist_Click(object sender, EventArgs e)
        {
            try
            {
                string artistName = artistTBox.Text;

                if (artistName == "")
                {
                    Exception ex = new Exception("Please, insert artist's name!");

                    throw ex;
                }

                string gName = genreBox.Text;
                Genre gID = Genre.GetGenreID(gName);
                Artist findartist = Artist.CheckArtist(artistName);

                Artist artist = new Artist();

                if (findartist == null)
                {
                    artist = new Artist(artistName, gID);
                    artist.Create();
                }
                else
                {
                    MessageBox.Show("Such artist already exists in your library!", "Whoops!");
                }
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }
    }
}
