using ConsoleApp.Interfaces;

namespace ConsoleApp.Models
{
    public class Sedan : ICar
    {
        public void Drive() => Console.WriteLine("I drive sedan!");
    }
}
