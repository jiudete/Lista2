using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3;
            Console.WriteLine("Digite o primeiro número:");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            a3 = double.Parse(Console.ReadLine());
            if (a1 > a2)
            {
                if (a2 > a3)
                {
                    Console.WriteLine("O primeiro e o segundo são maiores: " + a1 + ", " + a2);
                }
                else if (a3 > a2)
                {
                    Console.WriteLine("O primeiro e o terceiro são maiores: " + a1 + ", " + a3);
                }

            }
            else if (a2 > a1)
            {
                if (a1 > a3)
                {
                    Console.WriteLine("O segundo e o primeiro são maiores: " + a2 + ", " + a1);
                }
                else if (a3 > a1)
                {
                    Console.WriteLine("O segundo e o terceiro são maiores: " + a2 + ", " + a3);
                }

            }
            else if (a3 > a1)
            {
                if (a1 > a3)
                {
                    Console.WriteLine("O terceiro e o primeiro são maiores: " + a3 + ", " + a1);
                }
                else if (a2 > a1)
                {
                    Console.WriteLine("O terceiro e o segundo são maiores: " + a3 + ", " + a2);
                }
            }
            Console.ReadKey();
        }   
       

    }       
}
