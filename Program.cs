using ConsoleApp1;

var farmer = new Farmer("Danylo", "Ivaschenko", "vegetables");
var farm = new Farm("farm of Danylo", 6, farmer);

farm.AddPlant(new Tomato("Yellow tomato", 11, true,  0.4));
farm.AddPlant(new Tomato("Pink tomato", 24, true,  0.5));
farm.AddPlant(new Carrot("Small carrot", 46, true, Season.SPRING, 0.4, 2));
farm.AddPlant(new Carrot("Big carrot", 115, true, Season.SPRING, 0.4, 0.5));
farm.AddPlant(new Onion("Ukrainian cebulya", 120, true, Season.SPRING, 0.1, 0.2));
farm.AddPlant(new Cucumber("Big cucumber", 146, true, Season.SPRING, 0.1, 0.2));

foreach (var p in farm.PlantsOnGrowing)
{
    Console.WriteLine(p);
    Console.WriteLine("Can produce new crop:"+p.IsHarvest());
    Console.WriteLine();
}


