using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite.Net.Attributes;

namespace SQLiteExample
{
    public class ObservableItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(15)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
    }
}
