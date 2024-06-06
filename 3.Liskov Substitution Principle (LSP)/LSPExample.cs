using System;

// Before LSP: Subclass does not completely adhere to the behavior of the base class
public class Rectangle
{
    // Properties for width and height
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    // Method to calculate area
    public int GetArea()
    {
        return Width * Height;
    }
}

// Subclass for square, which violates LSP
public class Square : Rectangle
{
    // Overriding properties to maintain square's behavior
    public override int Width
    {
        set { base.Width = base.Height = value; }
    }

    public override int Height
    {
        set { base.Width = base.Height = value; }
    }
}

// After LSP: Using a base class that adheres to LSP

// Base class for shape with area calculation
public abstract class Shape
{
    // Abstract method to calculate area
    public abstract int GetArea();
}

// Class for rectangle
public class Rectangle : Shape
{
    // Properties for width and height
    public int Width { get; set; }
    public int Height { get; set; }

    // Overriding method to calculate area
    public override int GetArea()
    {
        return Width * Height;
    }
}

// Class for square
public class Square : Shape
{
    // Property for side length
    public int SideLength { get; set; }

    // Overriding method to calculate area
    public override int GetArea()
    {
        return SideLength * SideLength;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of Rectangle and Square
        Shape rectangle = new Rectangle { Width = 4, Height = 5 };
        Shape square = new Square { SideLength = 4 };

        // Calculating and displaying areas
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());
        Console.WriteLine("Square area: " + square.GetArea());
    }
}