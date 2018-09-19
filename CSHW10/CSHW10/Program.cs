using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW10
{
    class Program
    {
        // delegate declaration
        public delegate double Del(double del);

        public static double Sin(double x)
        {
            return 2 * Math.Pow(x, 2) + 3 * x * Math.Cos(Math.Pow(x, 3));
        }

        public static void Tabulation(Del del, double a, double b, int n)
        {            
            for(int k =0; k<=n; k++)
            {
                double x = (a + k * (b - a) / n);
                Console.WriteLine($"{x} {del(x)}");
            }
             
        }
        static void Main(string[] args)
        {
            Del del = Sin;
            Tabulation( del, 4, 5, 6);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
