using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Triângulo retângulo");
            Console.WriteLine("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor:");
            c = int.Parse(Console.ReadLine());
            if (Math.Pow( a,2 ) == Math.Pow( b,2) + Math.Pow( c , 2))
            {
                Console.WriteLine("É triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Não é um triângulo retângulo.");
            }
            Console.ReadKey();
        }
    }
}
