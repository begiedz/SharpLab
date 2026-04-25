using System.Globalization;

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

var us = CultureInfo.GetCultureInfo("en-US");

Console.WriteLine($"Dear {customerName},");

Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

Console.WriteLine($"Currently, you own {currentShares.ToString("C2", us)} shares at a return of {currentReturn:P2}\n");

Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit.ToString("C2", us)}.\n");


Console.WriteLine("Here's a quick comparison:\n");

var currentReturnPercent = $"{currentReturn:P2}";
var newReturnPercent = $"{newReturn:P2}";

var firstLine = string.Format("{0}{1}{2}", currentProduct.PadRight(15), currentReturnPercent.ToString().PadLeft(11), currentProfit.ToString("C", us).PadLeft(17));

var secondLine = string.Format("{0}{1}{2}", newProduct.PadRight(15), newReturnPercent.ToString().PadLeft(11), newProfit.ToString("C", us).PadLeft(17));

string comparisonMessage = $"{firstLine}\n{secondLine}";

Console.WriteLine(comparisonMessage);
