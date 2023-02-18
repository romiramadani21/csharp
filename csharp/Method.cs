using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Method
    {
      /*  static void Main(string[] args)
        {
            string nama = Hi("Romi");

            Console.WriteLine(nama);
            Console.ReadLine();
        }*/
        static void SayHi(string n)
        {
            Console.WriteLine("Hallo, Apa Kabar {0}", n);
        }

        static void Hitung(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static int jumlah(int n, int x)
        {
            return n + x;
        }

        static string Hi(string n)
        {
            return "Hallo, Apa Kabar " + n;
        }
    }
}
