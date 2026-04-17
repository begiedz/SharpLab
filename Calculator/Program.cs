Console.WriteLine(@"
Welcome to C# Calculator!

To make an operation select an operator:
+ = add
- = substract
* = multiply
/ = divide
");

while (true)
{
    Console.Write("First number: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Operator: ");
    char operatorChar = Convert.ToChar(Console.ReadLine());

    Console.Write("Second number: ");
    double b = Convert.ToDouble(Console.ReadLine());

    try
    {
        double result = Calculator.Calculate(a, b, operatorChar);
        Console.WriteLine($"{a} {operatorChar} {b} = {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.Write("Press Q to quit or any other key to continue: ");
    ConsoleKeyInfo key = Console.ReadKey(intercept: true);

    if (key.Key == ConsoleKey.Q)
        break;

    Console.WriteLine();

}


public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }

    public static double Calculate(double a, double b, char operatorChar) 
    {
        switch (operatorChar)
        {
            case '+':
                return Add(a, b);
            case '-':
                return Subtract(a, b);
            case '*':
                return Multiply(a, b);
            case '/':
                return Divide(a, b);
            default: throw new ArgumentException("Invalid operator.");

        }
    }
}