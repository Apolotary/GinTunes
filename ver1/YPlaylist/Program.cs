using System;
using Castle.ActiveRecord;
using Castle.Components;
using YPlaylist.BusinessLogic;
using Castle.Core;
using Castle.ActiveRecord.Framework.Config;
using Castle.DynamicProxy;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace YPlaylist
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Type[] t = { typeof(Lable), typeof(Album), typeof(AlbumFormat), typeof(Artist), typeof(Genre),
                       typeof(PlayList), typeof(TrackList), typeof(YearTable)};
            XmlConfigurationSource source = new XmlConfigurationSource("appconfig.xml");
            ActiveRecordStarter.Initialize(source, t); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm main = MainForm.Instance();
            Application.Run(main);
        }
    }
}
