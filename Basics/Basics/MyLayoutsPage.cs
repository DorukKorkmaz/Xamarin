using System;

using Xamarin.Forms;

namespace Basics
{
    public class MyLayoutsPage : ContentPage
    {
        public MyLayoutsPage()
        {
            Title = "Layouts";

            Label label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Text = "This page is created with StackLayout"
            };

            Button absoluteButton = new Button
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Text = "Go to Absolute Layout Page",
            };

            absoluteButton.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new MyAbsoluteLayoutPage());
            };

            Button relativeButton = new Button
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Text = "Go to Relative Layout Page"
            };

            relativeButton.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MyRelativeLayoutPage());
            };

            Button gridButton = new Button
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Text = "Go to Grid Layout Page"
            };

            gridButton.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MyGridLayoutPage());
            };

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    label,
                    absoluteButton,
                    relativeButton,
                    gridButton
                }
            };

            Padding = new Thickness(20, 20, 20, 20);
        }
    }
}

