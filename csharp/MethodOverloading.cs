using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class MethodOverloading
    {
       /* static void Main(string[] args)
        {

            MethodOverloading p1 = new MethodOverloading();
            p1.display(100, "Programming");
            p1.display("Programiz", 400);
            Console.ReadLine();
        }*/

        // method with int and string parameters 
        void display(int a, string b)
        {
            Console.WriteLine("int: " + a);
            Console.WriteLine("string: " + b);
        }

        // method with string andint parameter
        void display(string b, int a)
        {
            Console.WriteLine("string: " + b);
            Console.WriteLine("int: " + a);
        }
    }
}
