using System;
using System.Windows.Forms;
using YPlaylist.BusinessLogic;
using YPlaylist.View.Interfaces;

namespace YPlaylist.Presenter
{
    class AddMusicControlP
    {
        private readonly IAddMusicControl _addMusicControl;
        public AddMusicControlP()
        {
        }

        public AddMusicControlP(IAddMusicControl addMc)
        {
            _addMusicControl = addMc;
        }

        public void FillBox()
        {
            _addMusicControl.FormatBox = ReturnData.Retformat();
            _addMusicControl.GenreBox = ReturnData.Retgen();
            _addMusicControl.YearBox = ReturnData.Retyears();
            _addMusicControl.LableBox = ReturnData.Retlabel();
        }

        #region Small Add-by-Artist Method
        public void AddByArtistClick()
        {
            try
            {
                if (_addMusicControl.ArtistAdd == "")
                {
                    Exception ex = new Exception("Please, insert artist's name!");
                    throw ex;
                }
                Genre gId = Genre.GetGenreID(_addMusicControl.GenreAdd);
                Artist findartist = Artist.CheckArtist(_addMusicControl.ArtistAdd);
                Artist artist;
                if (findartist == null)
                {
                    artist = new Artist(_addMusicControl.ArtistAdd, gId);
                    artist.Create();
                }
                else
                {
                    MessageBox.Show("Such artist already exists in your library!", "Whoops!");
                }
                _addMusicControl.ShowSuccessMessage();
            }
            catch
            {
                _addMusicControl.ShowErrorMessage();
            }
        }
        #endregion

        #region Big Add Method
        public void AddButtClick()
        {
            try
            {
                if (_addMusicControl.ArtistAdd == "")
                {
                    Exception ex = new Exception("Please, insert artist's name!");
                    throw ex;
                }

                Genre gId = Genre.GetGenreID(_addMusicControl.GenreAdd);
                Artist findartist = Artist.CheckArtist(_addMusicControl.ArtistAdd);
                Artist artist;

                if (findartist == null)
                {
                    artist = new Artist(_addMusicControl.ArtistAdd, gId);
                    artist.Create();
                    artist = Artist.CheckArtist(_addMusicControl.ArtistAdd);
                }
                else
                {
                    artist = Artist.CheckArtist(_addMusicControl.ArtistAdd);
                }

                YearTable year = YearTable.GetYearID(_addMusicControl.YearAdd);

                if (year == null)
                {
                    year = new YearTable(_addMusicControl.YearAdd);
                    year.Create();
                    year = YearTable.GetYearID(_addMusicControl.YearAdd);
                }
                else
                {
                    year = YearTable.GetYearID(_addMusicControl.YearAdd);
                }

                Lable lable = Lable.GetLableId(_addMusicControl.LableAdd);

                if (lable == null)
                {
                    lable = new Lable(_addMusicControl.LableAdd);
                    lable.Create();
                    lable = Lable.GetLableId(_addMusicControl.LableAdd);
                }
                else
                {
                    lable = Lable.GetLableId(_addMusicControl.LableAdd);
                }

                AlbumFormat format = AlbumFormat.GetFormatId(_addMusicControl.FormatAdd);

                if (format == null)
                {
                    format = new AlbumFormat(_addMusicControl.FormatAdd);
                    format.Create();
                    format = AlbumFormat.GetFormatId(_addMusicControl.FormatAdd);
                }
                else
                {
                    format = AlbumFormat.GetFormatId(_addMusicControl.FormatAdd);
                }

                Album album = new Album(_addMusicControl.AlbumAdd, artist, year, lable, format);
                album.Create();
                album = Album.GetAlbumId(_addMusicControl.AlbumAdd);
                TrackList tl;

                for (int i = 0; i < _addMusicControl.TrackListAdd.Length; ++i)
                {
                    string tnum = "00";
                    string tname = "";
                    string tempp = "";
                    bool whitespace = false;
                    for (int j = 0; j < _addMusicControl.TrackListAdd[i].Length; ++j)
                    {
                        if (_addMusicControl.TrackListAdd[i][j] == ' ' && !whitespace)
                        {
                            whitespace = true;
                            tnum = tempp;
                            tempp = "";
                        }
                        else
                        {
                            tempp += _addMusicControl.TrackListAdd[i][j];
                        }
                    }
                    tname = tempp;
                    tl = new TrackList(tname, tnum, album);
                    tl.Create();
                }
                _addMusicControl.ShowSuccessMessage();
            }
            catch
            {
                _addMusicControl.ShowErrorMessage();
            }
        }
        #endregion
    }
}
