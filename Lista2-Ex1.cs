using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.Write("O 1º é o maior ");
            }
            else
            {
                Console.Write("O 2º é o maior");
            }
            Console.ReadKey();
        }
    }
}
