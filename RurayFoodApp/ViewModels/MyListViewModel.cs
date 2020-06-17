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
                Name = "Arroz Con Pollo Peruano",
                Image = "https://images-gmi-pmc.edge-generalmills.com/8b79836e-e3b4-4099-bf3b-79a21257b759.jpg",
                Precio = "S/10.00",
                DetallePrincipio = "Plato muy fácil de hacer.",
                DetalleSegunda = 
                "1.En una licuadora,licúa cilantro junto con la espinaca y agua como para hacer una pasta homogénea.Reserva." + Environment.NewLine +
                "2.Seca el pollo con papel toalla y sazona con sal y pimienta.En una olla se calienta el aceite a fuego medio y se fríe el pollo hasta que esté dorado por ambos lados, unos 7 minutos.Retira de la olla y ponlo en un plato." + Environment.NewLine +
                "3.En la misma olla fríe la cebolla, ajo y la pasta de ají amarillo, revolviendo por 5 minutos.Incorpora el cilantro y espinaca licuado,fríe por 3 minutos.Agrega la cerveza,caldo de pollo, y agrega el pollo en la olla." + Environment.NewLine +
                "4.Hierve, tapa y baja el fuego.Cuece por 20 minutos.Corrige la sazón con más sal y pimienta si fuera necesario." + Environment.NewLine +
                "5.En otra olla calienta 1 cucharada de aceite.Incorpora el arroz y revuélvelo bien.Agrega las alverjitas, zanahorias, pimiento, maíz, y 3 1 / 2 tazas del caldo que utilizaste para cocinar el pollo.Deja que rompa hervor, tapa, baja el fuego al mínimo y deja cocer por 20 a 25 minutos.Revuelve con un tenedor y volver a tapar." + Environment.NewLine +
                "6.Cuando el arroz esté a punto, servir en cuatro platos, poner encima una pierna de pollo y Salsa Criolla al costado.Si quieren también un poco del juguito en el que se coció el pollo." + Environment.NewLine +
                "7.Para hacer la Salsa Criolla, corta 1/2 cebolla roja en láminas muy delgadas a lo largo, lava bien y escurre. Mezcla con 1/2 tomate cortado en tiras muy finas, hojas de cilantro, sal, pimienta, jugo de 1 limón y 1 cucharada de aceite de oliva. Si desean le pueden agregar tiritas de ají."
                ,
                
                Ingredientes = "-1/2 Taza de hoja de cilantro" + Environment.NewLine +
                "-4 Hojas de espinaca"+ Environment.NewLine+
                "-Sal y pimienta" + Environment.NewLine +
                "-4 piernas y muslos de pollo, sin piel" + Environment.NewLine +
                "-1/4 taza de aceite vegetal" + Environment.NewLine +
                "-1 taza de cebolla picado" + Environment.NewLine +
                "-1 cucharada de ajo picado" + Environment.NewLine +
                "-1/2 taza de pasta de ají" + Environment.NewLine +
                "-1 taza de cerveza" + Environment.NewLine +
                "-2 tasas de caldo de pollo" + Environment.NewLine +
                "-1 taza de aceite vegetal" + Environment.NewLine +
                "-2 tazas de arroz de grano largo" + Environment.NewLine +
                "-1/4 taza de alvergitas" + Environment.NewLine +
                "-1/2 pimenton rojo, cortado " + Environment.NewLine +
                "-1 taza de maíz blanco " + Environment.NewLine +
                "-Salsa Criolla",
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Lomo Saltado",
                Image = "https://t2.rg.ltmcdn.com/es/images/5/7/4/lomo_saltado_peruano_11475_orig.jpg",
                Precio = "S/15.00",
                DetallePrincipio = "Rapido de hacer",
                DetalleSegunda = "1.Sazona la carne con ajo, sal y pimienta." + Environment.NewLine +
                "2.Coloca un wok o una sartén a fuego muy alto. Añade el aceite y saltea la carne, unas pocos tiras a la vez (2 minutos por tanda)para que no se suden, sino que se doren." + Environment.NewLine +
                "3.Agrega la cebolla, el tomate, el ají y saltea todo por aproximadamente 2 a 3 minutos. Los tomates y la cebolla deben estar crujientes, no blandos. Añade la salsa de soya y el vinagre a los lados del wok o la sartén y mezcla todo. Añade el caldo de carne (de res) y cocina 1 1/2 minutos más. Pruébalo para ajustar la sazón." + Environment.NewLine +
                "4.Apaga el fuego, agrega el cilantro picado y sírvelo inmediatamente con papas fritas y arroz blanco."                
                ,
                Ingredientes = "-1 libra de lomo de res cortado en tiras delgadas" + Environment.NewLine +
                "-2 dientes de ajo, finamente picados" + Environment.NewLine +
                "-Sal " + Environment.NewLine +
                "-Pimienta al gusto" + Environment.NewLine +
                "-3 cucharadas de aceite vegetal" + Environment.NewLine +
                "-1 cebolla morada (roja) pequeña, cortada en rodajas gruesas" + Environment.NewLine +
                "-2 tomates (jitomates) perita cortados en rodajas gruesas" + Environment.NewLine +
                "-1 ají amarillo sin semillas ni venas, cortado en tiras finas" + Environment.NewLine +
                "-2 cucharadas de salsa de soya" + Environment.NewLine +
                "-3 cucharadas de vinagre de vino tinto" + Environment.NewLine +
                "-1/3 taza de caldo de carne (caldo de res)" + Environment.NewLine +
                "-1/2 taza de cilantro fresco, picado grueso" + Environment.NewLine +
                "-2 tazas de papas fritas" + Environment.NewLine +
                "-Arroz blanco como acompañante "
                ,
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Ceviche",
                Image = "https://t2.rg.ltmcdn.com/es/images/7/4/1/ceviche_peruano_18147_600.jpg",
                Precio = "$19.00",
                DetallePrincipio = "Rico y facil de hacer.",
                DetalleSegunda = "1.Lo primero que debes hacer para poder elaborar el ceviche peruano es exprimir los 12 limones para extraer su jugo, resérvalo para más adelante.Luego, corta el pescado en trozos de 3 centímetros,aproximadamente.Coloca los trozos en el recipiente que vayas a utilizar para servir el plato." + Environment.NewLine +
                "2.Mezcla el pescado con el ají amarillo picado, el caldo de pescado y el cilantro.Coloca también la cebolla cortada en julianas y el ajo machacado.Déjalo reposar unos minutos para que se marine bien e se impregne de todos los sabores." + Environment.NewLine +
                "3.Salpimienta al gusto y coloca a un lado del plato el camote sancochado, la lechuga y el maíz tierno también hervido." + Environment.NewLine +
                "4.Después, vierte el zumo de limón por todo el plato de manera que quede todo bien cubierto. Por último, corta una lámina de ají limo rojo y colócala a modo de decoración. Resérvalo en el frigorífico para que se enfríe, puesto que este es un plato que se sirve frío. El ceviche peruano es un plato que actúa como aperitivo, por lo que puedes acompañarlo con un arroz con camarones o un delicioso salmón con salsa de gambas."
                ,
                Ingredientes = "-1 Pizca de pimienta" + Environment.NewLine +
                "-1 kilogramo de pescado de tu elección" + Environment.NewLine +
                "-1 cebolla cortada en julianas " + Environment.NewLine +
                "-¼ taza de taza cilantro de hoja picada" + Environment.NewLine +
                "-1 ají amarillo picado" + Environment.NewLine +
                "-1 ají limo picado (para decorar)" + Environment.NewLine +
                "-12 limones" + Environment.NewLine +
                "-1 pizca de sal y pimienta" + Environment.NewLine +
                "-1 taza de caldo de pescado" + Environment.NewLine +
                "-1 maíz tierno sancochado" + Environment.NewLine +
                "-1 camote sancochado (batata o boniato)" + Environment.NewLine +
                "-1 manojo de hojas de lechuga" 
                ,
            });
            FoodList.Add(new OrdenDeComida
            {
                Name = "Caldo de Gallina",
                Image = "https://img-global.cpcdn.com/recipes/a6941b2e92e20061/751x532cq70/caldo-de-gallina-peruano-foto-principal.jpg",
                Precio = "S/14.00",
                DetallePrincipio = "El mejor caldo",
                DetalleSegunda = "1.Poner a hervir en una olla grande los 5 litros de agua. Incorporar la gallina y los trozos de kion o jengibre. Añadir sal y sazonador al gusto. Cocinar por 3 horas aproximados a fuego medio." + Environment.NewLine +
                "2.Licuamos con un poco de caldo las papas crudas y los 3 huevos crudos). Reservar." + Environment.NewLine +
                "3.Pasada las 3 horas verificamos que la gallina este cocida luego incorporamos una mezcla de los huevos batidos en el caldo bien caliente, remover rápidamente por 2 minutos." + Environment.NewLine +
                "4.Servir inmediatamente con una porción de tallarines, una papa amarilla cocida, un huevo y el caldo acompañar con canchita y Cebollita china."
                ,
                Ingredientes = "-3 presas gallina" + Environment.NewLine +
                "-5 papas amarillas cocidas" + Environment.NewLine +
                "-4 granitos de pimienta chapa" + Environment.NewLine +
                "-3 huevos (crudos)" + Environment.NewLine +
                "-5 huevos duros" + Environment.NewLine +
                "-5 litros agua" + Environment.NewLine +
                "-1 pedazo kion pelado y cortado" + Environment.NewLine +
                "-1/2 kilo tallarines cocidos" + Environment.NewLine +
                "-Sal a gusto" + Environment.NewLine +
                "-Canchita serrana, Cebollita china, rocoto y limón" 
                ,
            });
           
        }

    }
}