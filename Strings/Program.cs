using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args) { 
        // Declare without initializing.
             string message1;

            // Initialize to null.
            //string? message2 = null;


            string s1 = "What is your favourite programming language?";
            //clone
            string message2 = (String)s1.Clone();
            //compare
            int compare = String.Compare(s1, message2);

            //compareOrdinal
            int compareOrdinal = String.CompareOrdinal("Is it equal","Is it equal");
            //CompareOrdinalTo
            int CompateOrdinalTo=String.

            Console.WriteLine(message2);
            Console.WriteLine(compare);
            Console.WriteLine(compareOrdinal);

            //other strings to look into
            /* concat 
               Copy
               EndsWith
               StartWiths
              

                             
             
             */


            Console.ReadLine();



        }
    }
}
