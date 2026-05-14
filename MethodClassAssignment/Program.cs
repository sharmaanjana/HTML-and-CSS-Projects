using System;

// Create a class named MathClass
class MathClass
{
    // Create a void method with two integer parameters
    public void DoMath(int number1, int number2)
    {
        // Multiply the first number by 2
        int result = number1 * 2;

        // Display the math result
        Console.WriteLine("First number multiplied by 2: " + result);

        // Display the second number
        Console.WriteLine("Second number is: " + number2);
    }
}

// Main program class
class Program
{
    // Main method - starting point of the program
    static void Main(string[] args)
    {
        // Instantiate the MathClass object
        MathClass mathObject = new MathClass();

        // Call the method by passing two numbers
        mathObject.DoMath(5, 10);

        // Call the method again using parameter names
        mathObject.DoMath(number1: 7, number2: 20);

        // Keep console window open
        Console.ReadLine();
    }
}
