using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            double area = baseRetangulo * alturaRetangulo;

            Console.WriteLine($"Área do retângulo: {area}");

            if (area > 100)
            {
                Console.WriteLine("terreno grande");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
       