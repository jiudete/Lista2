using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, Altura, Peso;
            Console.WriteLine("Digite a sua altura:");
            Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu peso:");
            Peso = double.Parse(Console.ReadLine());
            R = Peso / (Altura * Altura);
            if (R < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (20 <= R && R < 25)
            {
                Console.WriteLine("Peso ideal.");
            }
            else if (R >= 25)
            {
                Console.WriteLine("Acima do peso.");
            }
            Console.ReadKey();
        }
    }
}
