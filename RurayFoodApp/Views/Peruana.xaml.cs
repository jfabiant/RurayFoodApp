using RurayFoodApp.Model;
using RurayFoodApp.ViewModel;
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
    public partial class Peruana : ContentPage
    {
        public Peruana()
        {
            InitializeComponent();
            BindingContext = new MyListViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetail = e.Item as OrdenDeComida;
            await Navigation.PushAsync(new DetailPage(mydetail.Name, mydetail.Image, mydetail.Precio, mydetail.Ingredientes, mydetail.DetallePrincipio, mydetail.DetalleSegunda));

        }
    }
}