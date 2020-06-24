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
            FoodList.Add(new OrdenDeComida
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
            FoodList.Add(new OrdenDeComida
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
            FoodList.Add(new OrdenDeComida
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
            FoodList.Add(new OrdenDeComida
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