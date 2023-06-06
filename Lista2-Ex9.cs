using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sexo;
            double peso, altura, imc;
            Console.WriteLine("---Índice de massa corpórea---");
            Console.WriteLine("Digite o peso :");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o seu sexo:");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");
            sexo = int.Parse(Console.ReadLine());
            imc = peso / Math.Pow(altura, 2);
            if (sexo == 1)
            {
                if (imc <= 20)
            
                 Console.WriteLine(" Abaixo do peso");
            
                if (imc >= 20 && imc <= 25)
            
                 Console.WriteLine("Peso ideal");
            
                if (imc >= 25)
              
                 Console.WriteLine(" Acima do peso ");
            }
            if (sexo == 2)
            {
                if (imc <= 19) 
                {
                    Console.WriteLine(" Abaixo do peso ");
                }
                if (imc >= 19 && imc <= 24)
                {
                Console.WriteLine("Peso ideal");
                }
                if (imc > 24)
                {
                    Console.WriteLine("Acima do peso");
                }
            }
            Console.ReadKey();
        }
    }
}
