using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object
            Employee emp1 = new Employee();

            // Assign values to first employee
            emp1.Id = 1;
            emp1.FirstName = "Anjana";
            emp1.LastName = "Sharma";

            // Create second Employee object
            Employee emp2 = new Employee();

            // Assign values to second employee
            emp2.Id = 1;
            emp2.FirstName = "John";
            emp2.LastName = "Smith";

            // Compare employees using overloaded ==
            bool result = emp1 == emp2;

            // Display result
            Console.WriteLine("Are employees equal? " + result);

            // Keep console open
            Console.ReadLine();
        }
    }
}