using System;
using System.Collections.Generic;
using System.ComponentModel;
using NHibernate.ByteCode.Castle;
using YPlaylist.BusinessLogic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPlaylist
{
    public partial class GenreLableAdd : UserControl
    {
        public GenreLableAdd()
        {
            InitializeComponent();
            genreCombo.DataSource = Genre.ReturnAllGenreNames();
            labelCombo.DataSource = Lable.ReturnAllLableNames();
            formatCombo.DataSource = AlbumFormat.ReturnAllFormatNames();
            yearCombo.DataSource = YearTable.ReturnAllYearNames();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance().ChangeControl(new WelcomeControl());
        }

        private void addLabelButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = lableBox.Text;
                Lable nLable = new Lable(temp);
                nLable.Create();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
            
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = genreTBox.Text;
                Genre nGenre = new Genre(temp);
                nGenre.Create();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }

        private void addFormatButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = formatTBox.Text;
                AlbumFormat nFormat = new AlbumFormat(temp);
                nFormat.Create();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }

        private void addYear_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = yearBox.Text;
                YearTable year = new YearTable(temp);
                year.Create();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }

        private void remGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = genreCombo.Text;
                Genre gen = Genre.GetGenreID(temp);
                gen.Delete();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }

        }

        private void remLabelButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = labelCombo.Text;
                Lable gen = Lable.GetLableID(temp);
                gen.Delete();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }

        private void remFormatButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = formatCombo.Text;
                AlbumFormat gen = AlbumFormat.GetFormatID(temp);
                gen.Delete();
                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }

        private void remYearButton_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = yearCombo.Text;
                YearTable gen = YearTable.GetYearID(temp);
                gen.Delete();

                MessageBox.Show("Done!^_^", "TheResult");
            }
            catch
            {
                MessageBox.Show("Something bad has happened!", "Whoops!");
            }
        }
    }
}
