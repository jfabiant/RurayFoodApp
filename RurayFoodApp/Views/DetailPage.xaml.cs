using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RurayFoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string Name, string Image, string Precio, string DetallePrincipio, string DetalleSegunda, string Ingredientes)
        {


            InitializeComponent();

            FoodName.Text = Name;
            FoodIngredientes.Text = Ingredientes; 
            FoodPrecio.Text = Precio;
            FoodPrincipio.Text = DetallePrincipio;
            FoodImage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }

        private async void HacerPedido_Clicked(object sender, EventArgs e)
        {
            var newPage = new Mapa();
            await Navigation.PushAsync(newPage);
        }
    }
}