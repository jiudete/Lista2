using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, h;
            Console.WriteLine("Digite o valor da base:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            h = int.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("A area do seu terreno é: " + a + "cm");
            if (a > 100)
            {
                Console.WriteLine("Terreno Grande.");
            }
            else
            {
                Console.WriteLine("Terreno Pequeno.");
            }
            Console.ReadKey();
        }
    }
}
