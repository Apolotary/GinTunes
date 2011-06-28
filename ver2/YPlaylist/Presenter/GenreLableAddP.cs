using YPlaylist.BusinessLogic;
using System.Windows.Forms;
using YPlaylist.View.Interfaces;

namespace YPlaylist.Presenter
{
    class GenreLableAddP
    {
        private readonly IGenreLableAdd _iGenreLableAdd;

        // constructors
        public GenreLableAddP()
        {
        }

        public GenreLableAddP(IGenreLableAdd iGenreLableAdd)
        {
            _iGenreLableAdd = iGenreLableAdd;
        }

        // fill method
        public void FillBoxes()
        {
            _iGenreLableAdd.GenreBox = ReturnData.Retgen();
            _iGenreLableAdd.LableBox = ReturnData.Retlabel();
            _iGenreLableAdd.FormatBox = ReturnData.Retformat();
            _iGenreLableAdd.YearBox = ReturnData.Retyears();
        }

        #region Add Methods
        public void AddLableClick()
        {
            try
            {
                Lable nLable = new Lable(_iGenreLableAdd.LableAdd);
                nLable.Create();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }

        public void AddGenreClick()
        {
            try
            {
                Genre nGenre = new Genre(_iGenreLableAdd.GenreAdd);
                nGenre.Create();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }

        public void AddFormatClick()
        {
            try
            {
                AlbumFormat nFormat = new AlbumFormat(_iGenreLableAdd.FormatAdd);
                nFormat.Create();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }

        }

        public void AddYearClick()
        {
            try
            {
                YearTable year = new YearTable(_iGenreLableAdd.YearAdd);
                year.Create();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }
        #endregion

        #region Remove methods
        public void RemLableClick()
        {
            try
            {
                Lable gen = Lable.GetLableId(_iGenreLableAdd.LableRem);
                gen.Delete();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }

        public void RemGenreClick()
        {
            try
            {
                Genre gen = Genre.GetGenreID(_iGenreLableAdd.GenreRem);
                gen.Delete();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }

        public void RemFormatClick()
        {
            try
            {
                AlbumFormat gen = AlbumFormat.GetFormatId(_iGenreLableAdd.FormatRem);
                gen.Delete();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }

        public void RemYearClick()
        {
            try
            {
                YearTable gen = YearTable.GetYearID(_iGenreLableAdd.YearRem);
                gen.Delete();
                _iGenreLableAdd.ShowSuccessMessage();
            }
            catch
            {
                _iGenreLableAdd.ShowErrorMessage();
            }
        }
#endregion
    }
}
