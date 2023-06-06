using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, MÉDIA;
            Console.WriteLine("informe o valor de P1:");
            P1 = double.Parse(Console.ReadLine());
            P2 = ((5 * 3) - P1) / 2;
            Console.WriteLine("O valor de P2 é igual a: {0}",P2);
            Console.ReadKey();
        }
    }
}
