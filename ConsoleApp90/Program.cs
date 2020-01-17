using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void NWW(int a, int b)
        {
            int c, w;
            c = a * b;
            if (a>b)
            {
                for (int i=a; i>=b; i--)
                {
                    if (a > b) a -= b;
                    if (b > a) b -= a;
                }
            }
            if (b>a)
            {
                for (int i=b; i>=a; i--)
                {
                    if (a > b) a -= b;
                    if (b > a) b -= a;
                }
            }
            w = c / a;
            Console.WriteLine(w);
        }
        static void Main(string[] args)
        {
            NWW(16, 25);
            NWW(4, 14);
            NWW(40,10);
            Console.ReadKey();
        }
    }
}
