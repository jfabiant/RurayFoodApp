using RurayFoodApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RurayFoodApp.ViewModel
{
    public class MyListViewModel3
    {
        public ObservableCollection<OrdenDeComida> FoodList3 { get; set; }
        public MyListViewModel3()
        {
            FoodList3 = new ObservableCollection<OrdenDeComida>();
            FoodList3.Add(new OrdenDeComida
            {
                Name = "Suspiro Limeño",
                Image = "https://images-gmi-pmc.edge-generalmills.com/568c0d8a-4038-4d96-931b-a2afb848f6c8.jpg",
                Precio = "S/12.00",
                DetallePrincipio = "Postre mas delicioso.",
                DetalleSegunda =
                "1. Combinar la leche evaporada y condensada en una olla de fondo grueso, cocinar a fuego medio revolviendo, hasta que se caramelice y se vea de color del manjar (45 minutos). Al principio pueden revolver de vez en cuando, pero los últimos 15 minutos es mejor revolver todo el tiempo. Se va a espesar y al pasar la cuchara se puede ver el fondo de la olla por unos segundos. Bajar el fuego al mínimo." + Environment.NewLine +
                "2. En un bol batir las yemas por 30 segundos con un batidor de mano (globo-redondo), Agregar lentamente un cucharón de la mezcla de las leches en un hilo continuo y revolviendo todo el tiempo. Luego agregar las yemas a la olla, siempre revolviendo vigorosamente." + Environment.NewLine +
                "3. Cocinar por 2-3 minutos, revolviendo. Apagar el fuego y dejar enfriar 10-15 minuts, revolver ocasionalmente." + Environment.NewLine +
                "4. Colocar en las copas para servir." + Environment.NewLine +
                "5. Armar un baño María, y colocar en un bol el azúcar, claras y el vino, cocinar a baño María revolviendo hasta que el azúcar se disuelva totalmente. Apagar el fuego." + Environment.NewLine +
                "6. Batir con batidora hasta obtener un merengue sedoso y brillante, sobre el baño María apagado." + Environment.NewLine +
                "7. Colocar sobre el manjar blanco y espolvorear con canela." + Environment.NewLine +
                "8. Refrigerar o servir de inmediato."
                ,

                Ingredientes = "-1 Tarro (354 ml) de leche evaporada" + Environment.NewLine +
                "-1 Tarro (397 gr) de leche condensada" + Environment.NewLine +
                "-3 Huevos, separados" + Environment.NewLine +
                "-1 Taza de azúcar" + Environment.NewLine +
                "-1/4 Taza de vino dulce, oporto o marsala" + Environment.NewLine +
                "-Canela en polvo" 
                ,
            });
            FoodList3.Add(new OrdenDeComida
            {
                Name = "Dulce de Limón",
                Image = "https://t2.rg.ltmcdn.com/es/images/2/3/8/img_dulce_de_limon_con_galletas_23832_600.jpg",
                Precio = "S/10.00",
                DetallePrincipio = "Es el mas rico",
                DetalleSegunda =
                "1. En una taza coloque el jugo de los 7 limones. Después mezcle muy bien en la licuadora o con ayuda de la batidora la lata de leche evaporada clavel con la lata de lechera y una vez bien mezcladas, vacíe muy lentamente el jugo de los limones." + Environment.NewLine +
                "2. Coloque en un recipiente una capa de galletas María y después vierta un poco de la mezcla, y repita el procedimiento hasta que el recipiente esté totalmente lleno, después déjelo en el refrigerador toda la noche y aproximadamente media hora antes de servir puede adornarlo al gusto con frutas." + Environment.NewLine +
                "3. El dulce de limón con galletas es muy fácil de hacer y si tienes dudas puedes comparar su preparación con otras recetas parecidas como las de postre de limón fácil o la marquesa de limón." 
                 ,

                Ingredientes = "-1 Lata de Lechera (grande)" + Environment.NewLine +
                "-1 Lata de leche evaporada clavel" + Environment.NewLine +
                "-7 Unidades de Limones jugosos" + Environment.NewLine +
                "-1 Paquete de Grande de galletas María"
                ,
            });
            FoodList3.Add(new OrdenDeComida
            {
                Name = "Panqueques",
                Image = "https://t1.rg.ltmcdn.com/es/images/0/7/4/panqueques_super_faciles_de_hacer_51470_600.jpg",
                Precio = "S/10.00",
                DetallePrincipio = "Para el Desayuno",
                DetalleSegunda =
                "1. Hacer panqueques es súper fácil. Primero, reúne todos los ingredientes. Si no tienes harina leudante o preparada, que es harina de trigo que ya incluye levadura (también se llama harina de repostería), puedes usar harina de trigo normal y añadir una cucharadita de levadura química en polvo (polvo de hornear)." + Environment.NewLine +
                "2. Coloca la harina en un bol y añade el huevo y la leche. Mezcla bien hasta que se integren estos ingredientes y no queden casi grumos." + Environment.NewLine +
                "3. Para terminar de hacer la masa de los panqueques caseros, agrega un chorrito de aceite y mezcla bien. Verás que el aceite hace que se terminen de disolver los grumos de harina y quede una masa lisa y homogénea." + Environment.NewLine +
                "4. Para hacer los panqueques, calienta una sartén a fuego medio-bajo con un poquito de aceite o mantequilla. Cuando la sartén esté caliente, añade una cucharada de mezcla y déjala al fuego hasta que empiecen a salir burbujas en la superficie, entonces dale la vuelta y cocina por el otro lado." + Environment.NewLine +
                "5. Para servir la receta de panqueques súper fáciles de hacer, añade un poquito de mantequilla y miel y a disfrutar. Si quieres comerlos con algo salado, puedes servirlos con bacon y huevos fritos o un revuelto con jamón."
                ,

                Ingredientes = "-1 taza de harina leudante o harina de repostería" + Environment.NewLine +
                "-1 huevo" + Environment.NewLine +
                "-1 chorro de aceite de oliva" + Environment.NewLine +
                "-¾ taza de leche (180 mililitros)" + Environment.NewLine +
                "-1 cucharadita de mantequilla" + Environment.NewLine +
                "-1 chorro de miel"
                ,
            });
            FoodList3.Add(new OrdenDeComida
            {
                Name = "Picarones",
                Image = "https://www.perudelights.com/wp-content/uploads/2013/01/Picarones-1024x768.jpg",
                Precio = "S/15.00",
                DetallePrincipio = "Tradición de Perú",
                DetalleSegunda =
                "1. Pon el camote, el zapallo y el anís en una olla. Agrega agua que cubra todo y cocina a fuego medio hasta que el camote y el zapallo estén suaves. Escurre y reserva el agua. Pasa todo por el procesador de alimentos o aplasta con un prensador de papas para hacer una especie de puré muy suave. Coloca en un tazón." + Environment.NewLine +
                "2. Enfría el agua de la cocción hasta que esté tibia. En un tazón pon una taza de esta agua y el azúcar. Incorpora la levadura y revuelve hasta que se disuelvan. Tapa y deja reposar por 10 minutos en un lugar tibio para que se forme una esponja." + Environment.NewLine +
                "3. Agrega esta esponja al puré de camote y zapallo. Incorpora la harina y, mezclando con tus manos, añade ½ taza del agua de cocción. Sigue golpeando la masa con las manos hasta que ya no está pegajosa y se sienta suave y lisa. Tapa con un paño de cocina y deja reposar en un lugar tibio hasta que duplique o triplique el volumen, unas dos horas." + Environment.NewLine +
                "4. Cuando la masa está lista, calienta una buena cantidad de aceite en una olla grande." + Environment.NewLine +
                "5. El siguiente paso es fundamental para obtener la forma perfecta, pero con práctica vas a conseguirlo. " + Environment.NewLine +
                "6. Ten listo un tazón con agua fría. Humedece una mano y toma una porción de la masa. Rápidamente trata de hacerle un hueco en el centro con el pulgar, mientras que dejas que el círculo de masa se estire y se forme un aro liviano que vas a poner de inmediato en el aceite hirviendo. No lo tires, ponlo suavemente. " + Environment.NewLine +
                "7. Con un palito largo de madera dale vueltas en el centro para que no se pierda el hueco del centro y cuando esté dorado de un lado le das vuelta del otro. Esto es muy rápido." + Environment.NewLine +
                "8. Pon los picarones en platos (normalmente se sirven dos o tres) y baña con bastante miel de chancaca. " + Environment.NewLine +
                "9. Pica la chancaca o rállala gruesa y ponla en una olla con palitos de canela, clavos, hoja de higo, anís estrella, cáscara de piña y naranja. Cubre con agua y cocina a fuego medio, revolviendo ocasionalmente hasta que la chancaca se disuelva y se cocine hasta reducirse a un almíbar un poco espeso." + Environment.NewLine +
                "10. Cuela y descarta los sólidos, enfría a temperatura ambiente, pon en una jarra y tenla lista para bañar los picarones."
                 ,

                Ingredientes = "-½ kg de camotes anaranjados, pelados y picados)" + Environment.NewLine +
                "-¼ kg de zapallo macre, pelado y picado" + Environment.NewLine +
                "-2 Cucharaditas de anís" + Environment.NewLine +
                "-1 cucharada de azúcar" + Environment.NewLine +
                "-1 ¾ cucharada de levadura activa seca" + Environment.NewLine +
                "-½ kg de harina sin preparar" + Environment.NewLine +
                "-Aceite vegetal para freir" + Environment.NewLine +
                "-4 tazas de miel de chancaca" + Environment.NewLine +
                "-2 trozos de chancaca" + Environment.NewLine +
                "-2 palitos de canela" + Environment.NewLine +
                "-6 clavos de olor" + Environment.NewLine +
                "-1 hoja de higo (opcional)" + Environment.NewLine +
                "-2 anís estrella" + Environment.NewLine + 
                "-1 Paquete de Grande de galletas María" + Environment.NewLine +
                "-Cáscara de piña"
                ,
            });

        }
    }
}