using System;

using Xamarin.Forms;

namespace Basics
{
    public class MyAbsoluteLayoutPage : ContentPage
    {
        public MyAbsoluteLayoutPage()
        {
            AbsoluteLayout simpleLayout = new AbsoluteLayout
            {

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            BoxView topLeft = new BoxView
            {
                Color = Color.Blue
            };

            /*AbsoluteLayout.SetLayoutFlags(topLeft,
                AbsoluteLayoutFlags.None);*/

            AbsoluteLayout.SetLayoutBounds(topLeft,
                new Rectangle(0, 0, 200, 200));

            BoxView middle = new BoxView
            {
                Color = Color.Red
            };

            /*AbsoluteLayout.SetLayoutFlags(middle,
                AbsoluteLayoutFlags.None);*/

            AbsoluteLayout.SetLayoutBounds(middle,
                new Rectangle(100, 200, 200, 200));

            simpleLayout.Children.Add(topLeft);
            simpleLayout.Children.Add(middle);

            Content = simpleLayout;
        }
    }
}

