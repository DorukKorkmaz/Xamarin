using System;
using SQLite.Net;

namespace SQLiteExample
{
    public interface ISQLiteConnection
    {
        SQLiteConnection getConnection();
    }
}
