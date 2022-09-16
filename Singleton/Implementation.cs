using Console = System.Console;

namespace Singleton;

public class Logger
{
    private static readonly Lazy<Logger> _lazyLogger
        = new Lazy<Logger>(() => new Logger());
    // private static Logger? _instance;

    public static Logger Instance => _lazyLogger.Value;

    // public static Logger Instance => _instance ??= new Logger();

    protected  Logger()
    {
    }

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}