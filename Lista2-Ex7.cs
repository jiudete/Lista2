using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Digite o primeiro lado:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado:");
            n3 = double.Parse(Console.ReadLine());
            if (n1 == 0)
            {
                Console.WriteLine("Não é um triângulo.");
            }
            else if (n2 == 0)
            {
                Console.WriteLine("Não é um triângulo.");
            }
            else if (n3 == 0)
            {
                Console.WriteLine("Não é um triângulo.");
            }
            else if (n1 != 0 && n2 != 0 && n3 != 0)
            {
                if (n1 == n2 && n1 == n3 && n2 == n3)
                {
                    Console.WriteLine("O seu triângulo é equilátero.");
                }
                else if (n1 == n2 && n2 != n3)
                {
                    Console.WriteLine("O seu triângulo é isósceles.");
                }
                else if (n2 == n3 && n3 != n1)
                {
                    Console.WriteLine("O seu triângulo é isósceles.");
                }
                else if (n3 == n1 && n1 != n2)
                {
                    Console.WriteLine("O seu triângulo é isósceles.");
                }
                else if (n1 != n2 && n1 != n3 && n2 != n3)
                {
                    Console.WriteLine("O seu triângulo é escaleno.");
                }
            }
            Console.ReadKey();
        }
    }
}
