using System;

// Before OCP: A single class with a method that needs modification for new behavior
public class DiscountCalculator
{
    // Method to calculate discount
    public double CalculateDiscount(string customerType, double totalAmount)
    {
        if (customerType == "Regular")
        {
            return totalAmount * 0.1; // 10% discount for regular customers
        }
        else if (customerType == "Premium")
        {
            return totalAmount * 0.2; // 20% discount for premium customers
        }
        else
        {
            return 0; // No discount for other customers
        }
    }
}

// After OCP: Using inheritance to extend functionality without modifying existing code

// Base class for discount calculation
public abstract class DiscountCalculator
{
    // Abstract method to calculate discount
    public abstract double CalculateDiscount(double totalAmount);
}

// Class for regular customer discount calculation
public class RegularCustomerDiscount : DiscountCalculator
{
    // Overriding method to calculate discount for regular customers
    public override double CalculateDiscount(double totalAmount)
    {
        return totalAmount * 0.1; // 10% discount
    }
}

// Class for premium customer discount calculation
public class PremiumCustomerDiscount : DiscountCalculator
{
    // Overriding method to calculate discount for premium customers
    public override double CalculateDiscount(double totalAmount)
    {
        return totalAmount * 0.2; // 20% discount
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of RegularCustomerDiscount and PremiumCustomerDiscount
        DiscountCalculator regularDiscount = new RegularCustomerDiscount();
        DiscountCalculator premiumDiscount = new PremiumCustomerDiscount();

        // Calculating and displaying discounts
        Console.WriteLine("Regular customer discount: " + regularDiscount.CalculateDiscount(1000));
        Console.WriteLine("Premium customer discount: " + premiumDiscount.CalculateDiscount(1000));
    }
}
