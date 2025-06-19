
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lista2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());

            // Identifica o maior valor (hipotenusa)
            double hipotenusa = Math.Max(a, Math.Max(b, c));
            double cateto1, cateto2;

            if (hipotenusa == a)
            {
                cateto1 = b;
                cateto2 = c;
            }
            else if (hipotenusa == b)
            {
                cateto1 = a;
                cateto2 = c;
            }
            else
            {
                cateto1 = a;
                cateto2 = b;
            }

            // Verifica se é um triângulo retângulo
            if (Math.Pow(hipotenusa, 2) == Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo retângulo.");
            }

            Console.ReadKey();
        }
    }
}