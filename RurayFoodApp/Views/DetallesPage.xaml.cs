using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalles : ContentPage
    {
        public Detalles(string Name, string Image, string Precio, string DetallePrincipio, string DetalleSegunda, string Ingredientes)
        {
            InitializeComponent();
            FoodName.Text = Name;
            FoodIngredientes.Text = Ingredientes;
            
            FoodPrincipio.Text = DetallePrincipio;
            FoodImage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }
    }
}