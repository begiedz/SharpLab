using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Coffee";
        public double GetCost() => 5.0;
    }
}
