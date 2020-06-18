using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

using Xamarin.Essentials;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace RurayFoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {

        public Mapa()
        {
            InitializeComponent();

            string valueLatitude = Preferences.Get("user_location_latitude", "default_value");
            string valueLongitude = Preferences.Get("user_location_longitude", "default_value");

            double latitude = Double.Parse(valueLatitude);
            double longitude = Double.Parse(valueLongitude);

            MyMap.MoveToRegion(
                Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(
                    new Xamarin.Forms.Maps.Position(latitude, longitude), Distance.FromMiles(1)));

            var pinMyLocation = new Pin
            {
                Label = "Yo",
                Type = PinType.Place,
                Position = new Position(latitude, longitude)
            };
            var pinProv = new Pin
            {
                Label = "Proveedor RurayFood",
                Type = PinType.Place,
                Position = new Position(-12.019254, -76.886676)
            };

            MyMap.Pins.Add(pinProv);
            MyMap.Pins.Add(pinMyLocation);

            this.BindingContext = this;

        }

        private void Button_GoToPay(object sender, EventArgs e)
        {
            //var myValue = Preferences.Get("user_location_latitude", "default_value");
            //DisplayAlert("Information", $"The data saved is {myValue}", "ACEPTAR");



        }
    
    }


}