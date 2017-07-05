using System;

using Xamarin.Forms;

namespace Basics
{
    public class MyRelativeLayoutPage : ContentPage
    {
        public MyRelativeLayoutPage()
        {
            RelativeLayout simpleLayout = new RelativeLayout
            {

                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            BoxView topLeft = new BoxView
            {
                Color = Color.Blue
            };

            BoxView middle = new BoxView
            {
                Color = Color.Red
            };

            simpleLayout.Children.Add(topLeft, Constraint.Constant(50), Constraint.Constant(50), Constraint.Constant(50), Constraint.Constant(50));
            simpleLayout.Children.Add(middle,
                                      Constraint.RelativeToParent((parent) => { return parent.Width / 2; }),
                                      Constraint.RelativeToParent((parent) => { return parent.Height / 2; }),
                                      Constraint.Constant(50),
                                      Constraint.Constant(50));
            Content = simpleLayout;
        }
    }
}

