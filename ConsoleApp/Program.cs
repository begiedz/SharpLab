using ConsoleApp.Decorators;
using ConsoleApp.Factories;
using ConsoleApp.Interfaces;
using static ConsoleApp.Miscs.Calculator;
using ConsoleApp.Models;

// Logger logger = Logger.GetInstance();

// ICarFactory factory = new CarFactory();
// // CarFactory factory = new();

// logger.Log("Hello!");

// ICar car1 = factory.CreateCar("sedan");
// car1.Drive();

// ICar car2 = factory.CreateCar("suv");
// car2.Drive();

// ICoffee coffee = new SimpleCoffee();
// Console.WriteLine(coffee.GetDescription());
// Console.WriteLine(coffee.GetCost());

// coffee = new MilkDecorator(coffee);
// Console.WriteLine(coffee.GetDescription());
// Console.WriteLine(coffee.GetCost());

// coffee = new SugarDecorator(coffee);
// Console.WriteLine(coffee.GetDescription());
// Console.WriteLine(coffee.GetCost());

// // Dictionary (HashMap, frequency map)
// var dict = new Dictionary<string, int>();
// dict["apple"] = 3;
// dict["banana"] = 5;

// foreach (var keyValue in dict)
//     Console.WriteLine($"{keyValue.Key} -> {keyValue.Value}");

// // ===
// string[] items = { "apple", "banana", "apple", "pear", "banana", "banana" };

// var counts = new Dictionary<string, int>();
// foreach (var item in items)
//     counts[item] = counts.TryGetValue(item, out var count) ? count + 1 : 1;

// Console.WriteLine("Counts:");
// foreach (var pair in counts)
//     Console.WriteLine($"{pair.Key}: {pair.Value}");

// // HashSet
// var set = new HashSet<int>();
// set.Add(10);
// set.Add(20);

// foreach (var entry in set)
//     Console.WriteLine(entry);

var p1 = new Pizza("Quatro Formaggi", 45, "Sour Creme", "4 Cheese");
var p2 = new Pizza.PizzaBuilder();
var p3 = new Pizza.PizzaBuilder()
    .WithName("Diabolo")
    .WithSize(35)
    .WithSauce("Garlic")
    .WithTopping("Pepperoni")
    .Build();



Console.WriteLine(p1.Serve());
Console.WriteLine(p2.Build().Serve());
Console.WriteLine(p3.Serve());

Console.WriteLine(Sum(2.5, 5));
Console.WriteLine(Multiply(2, 5));
Console.WriteLine(Divide(2, 0));