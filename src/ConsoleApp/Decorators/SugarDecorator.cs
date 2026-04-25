using ConsoleApp.Interfaces;

namespace ConsoleApp.Decorators
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => base.GetDescription() + " with sugar";
        public override double GetCost() => base.GetCost() + 1.0;
    }
}
