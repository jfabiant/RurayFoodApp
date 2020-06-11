using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

using Xamarin.Essentials;

namespace RurayFoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {

        public Mapa()
        {
            InitializeComponent();

            MyMap.MoveToRegion(
                Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(
                    new Xamarin.Forms.Maps.Position(-12.019185, -76.886437), Distance.FromKilometers(300)));

            GetGeolocation();

            this.BindingContext = this;

        }

        public async void GetGeolocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    System.Console.WriteLine("### GEOLOCALITATION ###");
                    System.Console.WriteLine(location.Latitude.ToString());
                    System.Console.WriteLine(location.Longitude.ToString());
                    System.Console.WriteLine(location.Altitude.ToString());

                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception  
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception  
            }
            catch (Exception ex)
            {
                // Unable to get location  
            }
        }

    }


}