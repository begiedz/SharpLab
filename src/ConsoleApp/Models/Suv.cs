using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    public class Suv : ICar
    {
        public void Drive() => Console.WriteLine("I drive SUV!");
    }
}
