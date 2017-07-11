using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AutoListView
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
            await Navigation.PushAsync(new UpdatePage(selectedItem));

        }

        public async void onInsert(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsertPage(items));
        }

    }
}
