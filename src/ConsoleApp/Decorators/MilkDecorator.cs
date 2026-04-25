using ConsoleApp.Interfaces;

namespace ConsoleApp.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => base.GetDescription() + " with milk";
        public override double GetCost() => base.GetCost() + 2.0;
    }
}
