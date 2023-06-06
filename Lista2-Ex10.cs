using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, MEDIA;
            Console.WriteLine("Digite o valor da P1:");
            P1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da P2:");
            P2 = double.Parse(Console.ReadLine());
            MEDIA = (2 * P2  + P1) / 3;
            if (MEDIA >= 5)
            {
                Console.WriteLine("Aprovado: "+MEDIA);
            }
            else
            {
                Console.WriteLine("Reprovado: "+MEDIA);
            }
            Console.ReadKey();
        }
    }
}
