using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite.Net.Attributes;

namespace SQLiteExample
{
    public class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Item item;

        public ObservableItem()
        {
            item = new Item();
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(15)]
        public string Title
        {
            set
            {
                if (!value.Equals(item.Title, StringComparison.Ordinal))
                {
                    item.Title = value;
                    OnPropertyChanged("Title");
                }
            }
            get
            {
                return item.Title;
            }
        }

        [MaxLength(50)]
        public string Description
        {
            set
            {
                if (!value.Equals(item.Description, StringComparison.Ordinal))
                {
                    item.Description = value;
                    OnPropertyChanged("Description");
                }
            }
            get
            {
                return item.Description;
            }
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Item
    {
        public String Title { get; set; }
        public String Description { get; set; }
    }
}
