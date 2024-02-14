using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_scope
{
    internal class Program
    {     // This is a global variable, accessible throughout the entire class.
        static int globalVariable = 10;
        static void Main(string[] args)
        {

            // This is a local variable, only accessible within the Main method.
            int localVariable = 5;

            Console.WriteLine("Inside Main:");
            Console.WriteLine("Global Variable: " + globalVariable);
            Console.WriteLine("Local Variable: " + localVariable);

            // Calling another method that uses its own local variable.
            AnotherMethod();

            // Attempting to access a variable declared in AnotherMethod will result in a compilation error.
            // Uncommenting the line below will cause an error.
            // Console.WriteLine("Variable in AnotherMethod: " + anotherMethodVariable);
            Console.ReadLine();
        }

        static void AnotherMethod()
        {
            // This is a local variable for the AnotherMethod, not accessible outside of this method.
            int anotherMethodVariable = 20;

            Console.WriteLine("\nInside AnotherMethod:");
            Console.WriteLine("Global Variable: " + globalVariable);

            // LocalVariable from Main cannot be accessed in AnotherMethod.
            // Uncommenting the line below will cause an error.
            // Console.WriteLine("Local Variable from Main: " + localVariable);

            Console.WriteLine("Variable in AnotherMethod: " + anotherMethodVariable);
        }
    }
}
