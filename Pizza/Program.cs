using Pizzeria;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Pizza> pizzas = new List<Pizza>();

pizzas.Add(new Pizza(20, "Margherita (large)", true, 17.5f, "Tomatensaus", "Mozarella"));
pizzas.Add(new Pizza(16, "Hawaii (medium)", false, 18, "Tomatensaus", "Mozarella", "Ham", "Ananas"));
pizzas.Add(new Pizza(14, "Hawaii (small)", false, 16, "Tomatensaus", "Mozarella", "Ham", "Ananas"));
pizzas.Add(new Pizza(24, "Napolitana (extra large)", false, 21, "Tomatensaus", "Mozarella", "Ham", "Ananas"));

Console.WriteLine("Menukaart:");
foreach(var pizza in pizzas)
{
    pizza.Print_Naam_Prijs();
}

var bestelling = new List<Pizza>();
bestelling.Add(new Pizza(16, "Margherita (medium)", true, 15, "Tomatensaus", "Mozarella"));

Console.WriteLine("Bestelling:");
foreach (var pizza in bestelling)
{
    pizza.Print_Naam_Prijs();
}





