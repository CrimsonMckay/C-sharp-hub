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


           int result= Addition(2, 4);
            Console.WriteLine("Addition "+result);
            int result2=AbsoluteOfSum(-3, -4);

            Console.WriteLine("Abs "+ result2);
            PrintToScreen();


        }

       static public int Addition(int x,int y) { 
            //non void
            return x+y; 
        
        }

        static int AbsoluteOfSum(int x,int y) { 
        
        return Math.Abs(x+y);
        
        
        }
            
      static void PrintToScreen()
        {
            //void method
            Console.WriteLine("Hello There");
            Console.ReadLine();
        }
    }
}
