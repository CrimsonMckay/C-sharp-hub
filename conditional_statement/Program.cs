using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            if (Int32.Parse(age) < 18)
            {
                Console.WriteLine("You're not eligible to vote");
            }
            else
            {
                Console.WriteLine("Thanks for voting");

            }



            Console.ReadLine();


        }
    }
}
