using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static int smallest(int x, int y, int z)
        {
            int c = 0;

            while (x != 0 && y != 0 && z != 0)
            {
                x--;
                y--;
                z--;
                c++;
            }

            return c;
        }

        // Driver Code
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.Write("Minimum of 3"
                          + " numbers is " + smallest(x, y, z));
        }
    }
}
