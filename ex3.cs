using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        { // Entrada dos três valores
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            // Encontrar o maior valor
            int maior = Math.Max(valor1, Math.Max(valor2, valor3));

            // Exibir todos os valores que são iguais ao maior
            Console.WriteLine("Maior(es) valor(es):");
            if (valor1 == maior)
                Console.WriteLine(valor1);
            if (valor2 == maior && valor2 != valor1)
                Console.WriteLine(valor2);
            if (valor3 == maior && valor3 != valor1 && valor3 != valor2)
                Console.WriteLine(valor3);

            // Caso haja valores repetidos, garantir que todos sejam exibidos
            if ((valor1 == maior && valor2 == maior && valor1 != valor3) ||
                (valor1 == maior && valor3 == maior && valor1 != valor2) ||
                (valor2 == maior && valor3 == maior && valor2 != valor1) ||
                (valor1 == maior && valor2 == maior && valor3 == maior))
            {
                // Já exibidos acima, não é necessário repetir
            }

            Console.ReadKey();
        }
    }
    }