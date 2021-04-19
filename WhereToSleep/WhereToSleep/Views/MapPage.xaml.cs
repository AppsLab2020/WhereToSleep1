
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhereToSleep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MapPage : ContentPage
    {
       
        public MapPage()
        {
            InitializeComponent();

            GetPermissons();
        }
        private async void GetPermissons()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
            if (status != PermissionStatus.Granted)
            {
       
                if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                {
                    await DisplayAlert("We need your location", "We need to access your location", "OK");
                }

                var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                if (results.ContainsKey(Permission.LocationWhenInUse))
                status = results[Permission.LocationWhenInUse];
            }
            if(status == PermissionStatus.Granted)
            {
                LocationMap.IsShowingUser = true;
            }
                else
                {
                    await DisplayAlert("We need your location", "We need to access your location", "OK");
                }
           }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }


        private void SatelliteButton_Clicked(object sender, EventArgs e)
        {
            LocationMap.MapType = Xamarin.Forms.Maps.MapType.Satellite;
        }

        private void StandardButton_Clicked(object sender, EventArgs e)
        {
            LocationMap.MapType = Xamarin.Forms.Maps.MapType.Street;
        }

        private void HybridButton_Clicked(object sender, EventArgs e)
        {
            LocationMap.MapType = Xamarin.Forms.Maps.MapType.Hybrid;
        }
    }
}