using System;

// Before DIP: High-level module directly depends on low-level module
public class FileLogger
{
    // Method to log message to a file
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

public class Application
{
    private readonly FileLogger _logger = new FileLogger();

    // Method to perform an action
    public void DoWork()
    {
        _logger.Log("Work done");
    }
}

// After DIP: High-level module depends on an abstraction

// Interface for logger
public interface ILogger
{
    void Log(string message);
}

// Class implementing ILogger for file logging
public class FileLogger : ILogger
{
    // Implementing Log method
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

// Class implementing ILogger for console logging
public class ConsoleLogger : ILogger
{
    // Implementing Log method
    public void Log(string message)
    {
        Console.WriteLine("Logging to console: " + message);
    }
}

public class Application
{
    private readonly ILogger _logger;

    // Constructor injection of logger
    public Application(ILogger logger)
    {
        _logger = logger;
    }

    // Method to perform an action
    public void DoWork()
    {
        _logger.Log("Work done");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Using console logger
        ILogger logger = new ConsoleLogger();
        Application app = new Application(logger);
        app.DoWork();

        // Using file logger
        ILogger fileLogger = new FileLogger();
        Application fileApp = new Application(fileLogger);
        fileApp.DoWork();
    }
}