﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iHunter.Core;
using Xamarin.Forms;

namespace MobileApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new ContentPage {
            //	Content = new StackLayout {
            //		VerticalOptions = LayoutOptions.Center,
            //		Children = {
            //			new Label {
            //				XAlign = TextAlignment.Center,
            //				Text = "Welcome to Xamarin Forms!"
            //			}
            //		}
            //	}
            //};

            MainPage = GetMainPage();

        }

        public static Page GetMainPage()
        {
            return new RootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
