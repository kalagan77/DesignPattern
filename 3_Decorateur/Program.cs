using _3_Decorateur;


//readme => ne fonctionne pas comme attendu
//et à la page98 => Nous allons voir une bien meilleure façon de créer
//des objets décorés quand nous aborderons les
//patterns Fabrication et Monteur. Notez que
//Monteur est abordé dans l’annexe.

Boisson espresso = new Espresso();
Console.WriteLine(espresso.GetDescription() + ", " + espresso.Cout() + "euros");


Boisson b2 = new Colombia();
b2 = new IngredientChocolat(b2);
b2 = new IngredientChocolat(b2);
b2 = new IngredientCaramel(b2);
Console.WriteLine(b2.GetDescription() + ", " + b2.Cout() + "euros");
