using System;

// Before ISP: Single interface with too many responsibilities
public interface IWorker
{
    void Work();
    void Eat();
}

// Class implementing IWorker interface
public class Worker : IWorker
{
    // Implementing Work method
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    // Implementing Eat method
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// After ISP: Segregating interfaces based on responsibilities

// Interface for working
public interface IWorkable
{
    void Work();
}

// Interface for eating
public interface IFeedable
{
    void Eat();
}

// Class implementing IWorkable interface
public class Worker : IWorkable
{
    // Implementing Work method
    public void Work()
    {
        Console.WriteLine("Working...");
    }
}

// Class implementing both IWorkable and IFeedable interfaces
public class SuperWorker : IWorkable, IFeedable
{
    // Implementing Work method
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    // Implementing Eat method
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of Worker and SuperWorker
        IWorkable worker = new Worker();
        IWorkable superWorker = new SuperWorker();
        IFeedable feedableSuperWorker = new SuperWorker();

        // Performing actions
        worker.Work();
        superWorker.Work();
        feedableSuperWorker.Eat();
    }
}