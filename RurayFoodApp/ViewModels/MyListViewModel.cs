using RurayFoodApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace RurayFoodApp.ViewModel
{
    public class MyListViewModel
    {
        public ObservableCollection<OrdenDeComida> FoodList { get; set; }
        public MyListViewModel()
        {
            FoodList = new ObservableCollection<OrdenDeComida>();
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Arroz Con Pollo",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "$7.50",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda = "ajaksfbkabfjkasblfalbflas",
                Ingredientes = "asdnandlanlsdnl",
            });
        }

    }
}