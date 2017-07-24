using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class ListViewPage : ContentPage
    {

        ItemDatabase database;

        public ListViewPage()
        {
            InitializeComponent();
            database = new ItemDatabase();
            listView.BindingContext = database.GetObjects<ObservableItem>().ToList();
        }

        public void onDelete(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedItem = (ObservableItem)selectedMenuItem.BindingContext;
            database.DeleteObject<ObservableItem>(selectedItem.ID);
        }

        public void onUpdate(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedItem = (ObservableItem)selectedMenuItem.BindingContext;
            Navigation.PushAsync(new DetailPage(selectedItem));
        }

        public void onInsert(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        public void onRefresh(object sender, EventArgs e)
        {
            refreshList();
        }
        public void refreshList()
        {
            listView.BindingContext = database.GetObjects<ObservableItem>().ToList();
        }

        protected override void OnAppearing()
        {
            listView.BindingContext = database.GetObjects<ObservableItem>().ToList();
        }

    }


}
