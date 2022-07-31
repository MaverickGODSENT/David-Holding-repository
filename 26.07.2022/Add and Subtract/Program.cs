using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract
{
    internal class Program
    {
        static int Summing(int a, int b)
        {
            int c = a + b;
        }
        static int Subtract(int c, int x)
        {
             int f = c - x;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int c = Summing(a, b);
            Console.WriteLine(c, Subtract(c, x));
        }
    }
}
