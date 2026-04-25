/* 
    Factory - the factory of objects

    Idea: One space which know how to create objects
    Comparison: Don't build the car by yourself, you go to factory and you say "I want SUV" - and the factory returns complete product
 */
using ConsoleApp.Interfaces;
using ConsoleApp.Models;

namespace ConsoleApp.Factories
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(string type) =>
        type switch
        {
            "sedan" => new Sedan(),
            "suv" => new Suv(),
            _ => throw new ArgumentException("Unknown car type.")
        };
    }
}
