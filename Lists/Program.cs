using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {   //implicit use var
            /*  List<String> words = new List<String> { "One","two","zip","amigo" };

              Console.WriteLine("Count of elemnts is " + words.Count);

              words.Add("Hello");
              Console.WriteLine("Count of elemnts is " + words.Count);


              Console.WriteLine("Removing an item");
              words.Remove("Hello");
              words.RemoveAt(0);
              // var morewords = new List<String> { "four", "five", "six" };
              words.AddRange(new[] { "four", "five", "six" });

              Console.WriteLine($"Index of elemet 'four' is {words.IndexOf("four")}");
              Console.WriteLine($"Index of elemet 'four' is {words.IndexOf("fourw")}");
              Console.WriteLine($"Index of elemet 'four' is {words.Contains("fourw")}");

              foreach (var word in words)
              {
                  Console.WriteLine(word);
              }
            */

            //challenge- get only uppercase words

            var mixWords = new String[] {"PLANE","perfume","CAR","site","home","MANSION"};

            var filteredWords = new List<string>();

            foreach (var word in mixWords)
            {
                if (word.All(Char.IsUpper))
                {
                    filteredWords.Add(word);
                }
            }

            foreach(var word in filteredWords) { Console.WriteLine(word); }
            Console.ReadKey();   

        }
    }
}
