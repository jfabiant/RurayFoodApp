using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RurayFoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Diagnostics;

namespace RurayFoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string Name, string Image, string Precio, string DetallePrincipio, string DetalleSegunda, string Ingredientes)
        {


            InitializeComponent();

            FoodName.Text = Name;
            FoodPrecio.Text = Precio;
            FoodPrincipio.Text = DetallePrincipio;
            FoodImage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }

        private async void HacerPedido_Clicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });

                }

                if (location == null)
                {
                    await DisplayAlert("Information", "Por favor, active su GPS.", "Aceptar");
                }
                else
                {
                    //await DisplayAlert("Information", $"{location.Latitude} and {location.Longitude}", "OK");
                    Preferences.Set("user_location_latitude", location.Latitude);
                    Preferences.Set("user_location_longitude", location.Longitude);

                    var newPage = new Mapa();
                    await Navigation.PushAsync(newPage);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Something is wrong: {ex.Message}");

            }

            
        }
    }
}