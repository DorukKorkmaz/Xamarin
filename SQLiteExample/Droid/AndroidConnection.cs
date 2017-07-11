using System;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using SQLiteExample.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidConnection))]
namespace SQLiteExample.Droid
{
    public class AndroidConnection : ISQLiteConnection
    {
        public SQLiteConnection getConnection()
        {
            string documentPath = System.Environment.GetFolderPath(System.
                Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}
