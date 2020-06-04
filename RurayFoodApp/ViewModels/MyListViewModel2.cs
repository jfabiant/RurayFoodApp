using System;
using RurayFoodApp.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RurayFoodApp.ViewModel
{

    public class MyListViewModel2
    {
        public ObservableCollection<OrdenDeComida> FoodList2 { get; set; }
        public MyListViewModel2()
        {
            FoodList2 = new ObservableCollection<OrdenDeComida>();
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList2.Add(new OrdenDeComida
            {
                Name = "Plato Paceño",
                Image = "https://www.caserita.com/productos/images/La_PAz/gastro/IMG_0605.jpg",
                Precio = "$6.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });

        }
    }
}