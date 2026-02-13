namespace ConsoleApp.Miscs;

public static class Calculator
{
    public static double Sum(double x,double y) {
        return x + y;
    }

    public static double Subtract(double x, double y) {
        return x - y;
    }

    public static double Multiply(double x,double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        if (y == 0) throw new DivideByZeroException("y cannot be 0"); 
        return x / y;
    }
}
