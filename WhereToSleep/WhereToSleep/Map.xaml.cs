﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhereToSleep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();
        }

        void SipkaTapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        void MenuTapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}