/* 
    Singleton - one object for whole program
    
    Idea: one class instance for an app (logger, config)
    Comparison: Imagine a president - ​​there is only one president in a given country, and when someone says “President”, everyone knows who they are talking about.
 */
public class Logger
{
    private static Logger? _instance;
    private Logger() { } // private constructor

    public static Logger GetInstance()
    {
        if (_instance == null)
            _instance = new Logger();
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"> {message}");
    }
}
