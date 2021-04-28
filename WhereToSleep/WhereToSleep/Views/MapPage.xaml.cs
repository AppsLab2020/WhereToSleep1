
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

        private async void MapTypeButton_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Select Map Type", "Cancel", null, "Hybrid", "Satellite", "Standard");
            switch (action)
            {
                case "Hybrid":
                    LocationMap.MapType = Xamarin.Forms.Maps.MapType.Hybrid;
                    break;
                case "Satellite":
                    LocationMap.MapType = Xamarin.Forms.Maps.MapType.Satellite;
                    break;
                case "Standard":
                    LocationMap.MapType = Xamarin.Forms.Maps.MapType.Street;
                    break;
            }
                

        }
    }
}
