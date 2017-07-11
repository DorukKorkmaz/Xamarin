using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoListView
{
    public partial class UpdatePage : ContentPage
    {
        public UpdatePage(ObservableItem item)
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
