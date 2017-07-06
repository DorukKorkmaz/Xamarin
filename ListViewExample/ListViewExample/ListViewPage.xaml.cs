using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ListViewExample
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            listView.BindingContext = DSFactory.BindingWithGrouping();
            listView.GroupDisplayBinding = new Binding("Type");
            listView.Refreshing += (object sender, EventArgs e) =>
            {
                listView.BindingContext = DSFactory.BindingWithGrouping();
                listView.IsRefreshing = false;
            };
            searchBar.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                listView.BindingContext = DSFactory.BindingWithGrouping(e.NewTextValue);
            };

        }

        public void onTextChanged()
        {

        }
    }
}
