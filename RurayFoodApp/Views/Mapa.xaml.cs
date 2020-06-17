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
            //MyMap.Pins({ Position()});

            this.BindingContext = this;

        }

        private void Button_GoToPay(object sender, EventArgs e)
        {

        }
    }


}