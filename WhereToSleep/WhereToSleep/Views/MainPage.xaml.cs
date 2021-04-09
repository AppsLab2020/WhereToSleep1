using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WhereToSleep.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       


        SearchBar searchBar = new SearchBar 
        { 
            Placeholder = "Search items..." 
        };

        void OnButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = true;
        }
     

        void OnOKButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;             
        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }


        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;

            resultLabel.Text = String.Format("{0} day{1} between dates",
                                                timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }




    }
}
