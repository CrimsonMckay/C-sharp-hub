using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers=new int[] { 2,3,4,5,7,1,9,0};
          

            var firstFromEnd = numbers[numbers.Length - 1];
            // var LastButOne = numbers[^2];

            var sum = 0;
            Console.WriteLine($"Last Element {firstFromEnd}");
            for(int i=0;i<numbers.Length;i++)
            {
                sum+= numbers[i];
            }
            Console.WriteLine("sum of elements is " + sum);
            /*<-------------------------Multidimensional Arrays----------------------->*/
            char[,] letters = new char[2, 3];

            letters[0,0]= 'a';
            letters[0, 1] = 'b';
            letters[0, 2] = 'c';
            letters[1, 0] = 'd';
            letters[1, 1] = 'e';
            letters[1, 2] = 'F';


            var letters2=new char[,]{ { 'A','B','C'},{'D','E','F'} };

            for(int i=0;i<letters2.GetLength(0);i++)
            {
                for (int j = 0; j < letters2.GetLength(1); j++)
                {
                    Console.WriteLine("Content "+ letters2[i,j]);
                }

            }

            Console.ReadKey();
        }
    }
}
