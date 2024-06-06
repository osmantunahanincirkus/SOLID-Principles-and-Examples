using System;

// Before SRP: A single class handling both authentication and user data retrieval
public class UserService
{
    // Method to authenticate a user
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
        Console.WriteLine("Authenticating user...");
    }

    // Method to get user details
    public void GetUserDetails(int userId)
    {
        // Logic to get user details
        Console.WriteLine("Getting user details...");
    }
}

// After SRP: Separating responsibilities into different classes

// Class dedicated to user authentication
public class AuthenticationService
{
    // Method to authenticate a user
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
        Console.WriteLine("Authenticating user...");
    }
}

// Class dedicated to user data retrieval
public class UserService
{
    // Method to get user details
    public void GetUserDetails(int userId)
    {
        // Logic to get user details
        Console.WriteLine("Getting user details...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of AuthenticationService and UserService
        AuthenticationService authService = new AuthenticationService();
        UserService userService = new UserService();

        // Authenticating user
        authService.AuthenticateUser("user", "password");

        // Getting user details
        userService.GetUserDetails(1);
    }
}