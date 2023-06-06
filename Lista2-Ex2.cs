using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Digite o primeiro valor:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            b = double.Parse(Console.ReadLine());
            if (a > b )
            {
                Console.WriteLine("O maior numero é: "+ a);
            }
            else if (b > a)
            {
                Console.WriteLine("O maior numero é: "+ b);
            }
            else
            {
                Console.WriteLine("Os numeros são iguais.");
            }
            Console.ReadKey();
        }
    }
}
