using System;
using YPlaylist.BusinessLogic;
using System.Windows.Forms;
using YPlaylist.View.Interfaces;

namespace YPlaylist.Presenter
{
    class MusicLibControlP
    {
        private readonly IMusicLibControl _musicLibControl;

        public MusicLibControlP()
        {
        }

        public MusicLibControlP(IMusicLibControl mlc)
        {
            _musicLibControl = mlc;
        }

        #region Fill Methods
        public void FillBox()
        {
            _musicLibControl.ArtistFBox = ReturnData.Retartists();
            _musicLibControl.FormatFBox = ReturnData.Retformat();
            _musicLibControl.GenreFBox = ReturnData.Retgen();
            _musicLibControl.LableFBox = ReturnData.Retlabel();
            _musicLibControl.YearFBox = ReturnData.Retyears();
        }

        public void FillAlbums()
        {
            try
            {
                _musicLibControl.AlbumFBox = ReturnData.Retalbums(Artist.CheckArtist(_musicLibControl.ArtistAdd));
            }
            catch 
            {
                _musicLibControl.ShowErrorMessage();
            }
        }
        #endregion

        #region Search Method
        public void searchButtonClick()
        {
            try
            {
                if (_musicLibControl.AlbumAdd == "")
                {
                    Artist ar = Artist.CheckArtist(_musicLibControl.ArtistAdd);
                    _musicLibControl.Pelems = TrackList.FillElemsByArtist(ar);
                }
                else
                {
                    Artist ar = Artist.CheckArtist(_musicLibControl.ArtistAdd);
                    Album al = Album.GetAlbumId(_musicLibControl.AlbumAdd);
                    _musicLibControl.Pelems = TrackList.FillElemsByAlbum(ar, al);
                }
                _musicLibControl.TShow = true;
                _musicLibControl.ContentGrid.DataSource = _musicLibControl.Pelems;
                _musicLibControl.ContentGrid.Invalidate();
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }
        #endregion

        #region Remove Methods
        public void RemAlbButtonClick()
        {
            try
            {
                if (_musicLibControl.TShow)
                {
                    Album al = Album.GetAlbumId(_musicLibControl.AlbumAdd);
                    al.Delete();
                    _musicLibControl.ShowSuccessMessage();
                }
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }

        public void RemArtButtonClick()
        {
            try
            {
                if (_musicLibControl.TShow)
                {
                    Artist ar = Artist.CheckArtist(_musicLibControl.ArtistAdd);
                    ar.Delete();
                    _musicLibControl.ShowSuccessMessage();
                }
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }

        }

        public void remTracksClick()
        {
            try
            {
                if (_musicLibControl.TShow)
                {
                    Int32 selectedRowCount =
                    _musicLibControl.ContentGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    int[] row = new int[selectedRowCount];
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        row[i] = _musicLibControl.ContentGrid.SelectedRows[i].Index;
                    }
                    for (int i = 0; i < selectedRowCount; ++i)
                    {
                        TrackList trtemp = TrackList.GetTrackId(_musicLibControl.Pelems[row[i]].TrackName);
                        trtemp.Delete();
                    }
                    _musicLibControl.ShowSuccessMessage();
                }
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }
        #endregion

        #region Add / Search Methods
        public void GenreLabelClick()
        {
            try
            {
                Lable lb = Lable.GetLableId(_musicLibControl.LableAdd);
                _musicLibControl.Pelems = TrackList.FillElemsByLabel(lb);
                _musicLibControl.ContentGrid.DataSource = _musicLibControl.Pelems;
                _musicLibControl.ContentGrid.Invalidate();
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }

        public void GenreFormatClick()
        {
            try
            {
                AlbumFormat af = AlbumFormat.GetFormatId(_musicLibControl.FormatAdd);
                _musicLibControl.Pelems = TrackList.FillElemsByFormat(af);
                _musicLibControl.ContentGrid.DataSource = _musicLibControl.Pelems;
                _musicLibControl.ContentGrid.Invalidate();
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }
        public void GenreSearchClick()
        {
            try
            {
                Genre ge = Genre.GetGenreID(_musicLibControl.GenreAdd);
                _musicLibControl.Pelems = TrackList.FillElemsByGenre(ge);
                _musicLibControl.ContentGrid.DataSource = _musicLibControl.Pelems;
                _musicLibControl.ContentGrid.Invalidate();
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }

        public void YearSearchClick()
        {
            try
            {
                YearTable yr = YearTable.GetYearID(_musicLibControl.YearAdd);
                _musicLibControl.Pelems = TrackList.FillElemsByYear(yr);
                _musicLibControl.ContentGrid.DataSource = _musicLibControl.Pelems;
                _musicLibControl.ContentGrid.Invalidate();
            }
            catch
            {
                _musicLibControl.ShowErrorMessage();
            }
        }
        #endregion
    }
}
