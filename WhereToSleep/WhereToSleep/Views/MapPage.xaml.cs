﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using WhereToSleep.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace WhereToSleep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MapPage : ContentPage
    {
        private bool hasLocationPermission = false;
        private IList<Pin> allPins;
        public MapPage()
        {
            InitializeComponent();
            BindingContext = new PinItemsViewModel();

            GetPermissions();
            allPins = new List<Pin>(LocationMap.Pins);
        }
        private async void GetPermissions()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                    {
                        await DisplayAlert("Need your location", "We need to access your location", "Ok");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                    if (results.ContainsKey(Permission.LocationWhenInUse))
                        status = results[Permission.LocationWhenInUse];
                }

                if (status == PermissionStatus.Granted)
                {
                    hasLocationPermission = true;
                    LocationMap.IsShowingUser = true;

                    GetLocation();
                }
                else
                {
                    await DisplayAlert("Location denied", "You didn't give us permission to access location, so we can't show you where you are", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
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
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;

                locator.PositionChanged += Locator_PositionChanged;
                await locator.StartListeningAsync(TimeSpan.Zero, 100);
            }

            GetLocation();
           
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            CrossGeolocator.Current.StopListeningAsync();
            CrossGeolocator.Current.PositionChanged -= Locator_PositionChanged;
        }

        void Locator_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            MoveMap(e.Position);
        }

        private async void GetLocation()
        {
            if (hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync();

                MoveMap(position);
            }
        }

        private void MoveMap(Plugin.Geolocator.Abstractions.Position position)
        {
            var center = new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, 1, 1);
            LocationMap.MoveToRegion(span);
        }
        

        private void SearchButton_SearchButtonPressed(object sender, EventArgs e)
        {
            var foundPlaces = new List<Pin>();
            foreach (var pin in allPins)
            {
                if (pin.Label.ToLower().Contains(SearchButton.Text.ToLower()))
                {
                    foundPlaces.Add(pin);
                }
            }
            LocationMap.Pins.Clear();
            foreach (var pin in foundPlaces)
            {
                LocationMap.Pins.Add(pin);
            }
        }
    }
}
