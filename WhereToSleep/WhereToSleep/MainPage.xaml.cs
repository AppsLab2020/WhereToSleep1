using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WhereToSleep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void navig_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Map();
        }


        SearchBar searchBar = new SearchBar 
        { 
            Placeholder = "Search items..." 
        };


    }
}
