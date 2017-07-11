using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(ObservableItem item)
        {
            InitializeComponent();
            titleCell.Text = item.Title;
            descriptionCell.Text = item.Description;

            updateButton.Clicked += (object sender, EventArgs e) =>
            {
                item.Title = titleCell.Text;
                item.Description = descriptionCell.Text;
                Navigation.PopAsync();
            };
        }


    }
}
