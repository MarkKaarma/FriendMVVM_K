﻿using FriendMVVM_K.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendMVVM_K
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new FriendsListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
