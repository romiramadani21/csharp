using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Arguments
    {
       /* static void Main(string[] args)
        {
            int a = 5;
            Hitung(ref a);
            int b = 7;
            getNilai(out a, out b);

            Console.WriteLine(a + " " + b);
            Console.ReadLine();
        }*/

        static void getNilai(out int x, out int y)
        {
            x = 15;
            y = 12;
        }

        static void Hitung(ref int x)
        {
            x = x * x;
        }
    }
}
