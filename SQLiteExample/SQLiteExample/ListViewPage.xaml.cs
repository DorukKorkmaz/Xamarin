using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class ListViewPage : ContentPage
    {

        public ObservableCollection<ObservableItem> items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();

            items = new ObservableCollection<ObservableItem> {
                new ObservableItem {Title = "First", Description="1st item"},
                new ObservableItem {Title = "Second", Description="2nd item"},
                new ObservableItem {Title = "Third", Description="3rd item"}
            };

            listView.ItemsSource = items;

        }

        public void onDelete(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedItem = (ObservableItem)selectedMenuItem.BindingContext;
            items.Remove(selectedItem);
        }

        public async void onUpdate(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedItem = (ObservableItem)selectedMenuItem.BindingContext;
            await Navigation.PushAsync(new DetailPage(selectedItem));

        }

        public async void onInsert(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsertPage(items));
        }

    }

    public class Item
    {
        public String Title { get; set; }
        public String Description { get; set; }
    }

    public class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Item item;

        public ObservableItem()
        {
            item = new Item();
        }

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
}
