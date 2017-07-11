using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();

            insertButton.Clicked += (object sender, EventArgs e) =>
            {
                ObservableItem item = new ObservableItem
                {
                    Title = titleCell.Text,
                    Description = descriptionCell.Text
                };

                ItemDatabase database = new ItemDatabase();
                database.SaveObject<ObservableItem>(item);
                Navigation.PopAsync();
            };
        }
    }
}
