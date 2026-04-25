/* 
    Decorator - Function Wrapping

    Idea: You can add new functionality to an object without changing its code.
    Analogy: You have coffee, but you can add milk, sugar, or syrup - coffee is still coffee, but with additional features.
 */
using ConsoleApp.Interfaces;

namespace ConsoleApp.Decorators
{
    // common template for specific decorator
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;
        protected CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

        public virtual string GetDescription() => _coffee.GetDescription();
        public virtual double GetCost() => _coffee.GetCost();
    }
}
