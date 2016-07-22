using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapExample
{
    public class App : Application
    {
        public App()
        {
            var map = new Map();
            map.IsShowingUser = true;

            var rootPage = new ContentPage();
            rootPage.Content = map;

            MainPage = rootPage;
        }
    }
}