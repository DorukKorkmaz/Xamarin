using System;
using SQLite.Net;

namespace SQLiteExample.Droid
{
    public class SQLiteConnection : ISQLiteConnection
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
