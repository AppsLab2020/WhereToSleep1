using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WhereToSleep.Models;
using Xamarin.Forms.Maps;

namespace WhereToSleep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPlace : ContentPage
    {

        PlaceModel myValue = new PlaceModel();

        public MapPlace(PlaceModel place)
        {
            InitializeComponent();
            myValue = place;

            Position position = new Position(myValue.latitute, myValue.longitute);
            MapSpan mapSpan = new MapSpan(position, 0.1, 0.1);
            Map MyMap = new Map(mapSpan);

            Pin pin = new Pin
            {
                Position = new Position(myValue.latitute, myValue.longitute),
                Label = myValue.StallName,
                Address = myValue.Description
            };

            MyMap.Pins.Add(pin);

            container.Children.Add(MyMap);
        }

        public event EventHandler<Xamarin.Forms.Maps.PinClickedEventArgs> InfoWindowClicked;
    }
}