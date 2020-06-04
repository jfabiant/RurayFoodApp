using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

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
                    new Xamarin.Forms.Maps.Position(19.46543, -90.45878), Distance.FromKilometers(30)));
        }
    }
}