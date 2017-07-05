using System;
using Basics;
using Xamarin.Forms;

namespace Views
{
    public class MyTabPage : TabbedPage
    {
        public MyTabPage()
        {
            Children.Add(new MyViewsPage());
            var navigationPage = new NavigationPage(new MyLayoutsPage());
            navigationPage.Title = "Layouts";
            Children.Add(navigationPage);
        }
    }
}

