namespace ConsoleApp.Models;

public class Pizza
{
    public string Name { get; }
    public int Size { get; }
    public string Sauce { get; }
    public string Topping { get; }

    public Pizza(string name, int size, string sauce, string topping)
    {
        Name = name;
        Size = size;
        Sauce = sauce;
        Topping = topping;
    }

    public string Serve() { return $"Pizza: {Name}. Size: {Size}cm, Sauce: {Sauce}, Topping: {Topping}"; }

    public sealed class PizzaBuilder
    {
        private string _name = "standard";
        private int _size = 30;
        private string _sauce = "tomato";
        private string _topping = "cheese";

        public PizzaBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public PizzaBuilder WithSize(int size)
        {
            _size = size;
            return this;
        }

        public PizzaBuilder WithSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }

        public PizzaBuilder WithTopping(string topping)
        {
            _topping = topping;
            return this;
        }

        public Pizza Build()
        {
            if (string.IsNullOrWhiteSpace(_name)) throw new ArgumentException("Name is required.");
            if (_size <= 0) throw new ArgumentException("Size must be grater than 0");
            return new Pizza(_name, _size, _sauce, _topping);
        }
    }
}
