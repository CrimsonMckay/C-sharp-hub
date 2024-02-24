using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] words = new String[] { "Hi", "Hello", "Heya", "speak", "amigo" };

            //forEach
            foreach (string placeholder in words)
            {
                Console.WriteLine(placeholder);
            }

            //for loop
            for(int i = 0;i< words.Length;i++)
            {
                Console.WriteLine($"Traditional for Loop says {words[i]}");
            }

            //while loop
            Console.WriteLine("Enter a word");
            var userInput =Console.ReadLine();

            while (userInput.Length < 15)
            {
                userInput += 'a';
                Console.WriteLine(userInput);
            }
            //Do while loop

            string word;
            do
            {
                Console.WriteLine("Enter a word Longerr than 10 letter");
                word= Console.ReadLine();
            }
            while(word.Length < 10);
             

            Console.WriteLine("Looping is done");
            Console.ReadKey();
            
        }
    }
}
