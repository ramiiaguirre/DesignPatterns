ChefSandwichDirector chef = new ChefSandwichDirector(new SandwichClassicBuilder());
Sandwich sandwich = chef.MakeSandwich().GetSandwich();
Console.WriteLine($"Price of first Order: ${sandwich.CalculetePrice()}");

chef.SetChefBuilder(new SandwichGlutenFreeBuilder());
sandwich = chef.MakeSandwich().GetSandwich();
Console.WriteLine($"Price of second Order: ${sandwich.CalculetePrice()}");

chef.SetChefBuilder(new SandwichVeganBuilder());
sandwich = chef.MakeSandwich().GetSandwich();
Console.WriteLine($"Price of third Order: ${sandwich.CalculetePrice()}");

chef.SetChefBuilder(new SandwichVeggieBuilder());
sandwich = chef.MakeSandwich().GetSandwich();
Console.WriteLine($"Price of fourth Order: ${sandwich.CalculetePrice()}");