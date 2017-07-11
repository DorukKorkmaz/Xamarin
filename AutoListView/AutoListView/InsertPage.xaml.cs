using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AutoListView
{
    public partial class InsertPage : ContentPage
    {
        public InsertPage(ObservableCollection<ObservableItem> items)
        {
            InitializeComponent();

            insertButton.Clicked += (object sender, EventArgs e) =>
            {
                ObservableItem item = new ObservableItem
                {
                    Title = titleCell.Text,
                    Description = descriptionCell.Text
                };

                items.Add(item);
                Navigation.PopAsync();
            };
        }
    }
}
