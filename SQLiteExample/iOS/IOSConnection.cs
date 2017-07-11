using System;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using SQLiteExample.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(IOSConnection))]
namespace SQLiteExample.iOS
{
    public class IOSConnection : ISQLiteConnection
    {
        public IOSConnection()
        {
        }

        public SQLiteConnection getConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}
