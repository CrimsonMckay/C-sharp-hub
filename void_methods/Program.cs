using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_methods
{
     class Program
    {
        static void Main(string[] args)
        {


           int result= addition(2, 4);
            Console.WriteLine(result);  
            PrintToScreen();


        }

       static public int addition(int x,int y) { 
            //non void
            return x+y; 
        
        }

      static void PrintToScreen()
        {
            //void method
            Console.WriteLine("Hello There");
            Console.ReadLine();
        }
    }
}
