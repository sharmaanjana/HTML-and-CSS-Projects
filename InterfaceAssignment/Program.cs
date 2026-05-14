using System;

// Create an interface named IQuittable
interface IQuittable
{
    // Define a void method named Quit
    void Quit();
}

// Create the Employee class
// Employee inherits the IQuittable interface
class Employee : IQuittable
{
    // Property for employee name
    public string Name { get; set; }

    // Implement the Quit() method from the interface
    public void Quit()
    {
        // Display message when Quit() method is called
        Console.WriteLine(Name + " has quit the job.");
    }
}

// Main program class
class Program
{
    // Main method - starting point of the program
    static void Main(string[] args)
    {
        // Create object using interface type (polymorphism)
        IQuittable employee = new Employee();

        // Cast object to Employee so we can set Name property
        ((Employee)employee).Name = "Anjana";

        // Call Quit() method using interface object
        employee.Quit();

        // Keep console window open
        Console.ReadLine();
    }
}
