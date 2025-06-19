using System;



namespace Lista2ex22
{
    internal class Program
    {
        private static void Main(string[] strings)
        {
            Console.Write("Digite o primeiro valor: ");
            if (!double.TryParse(Console.ReadLine(), out double valor1))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.Write("Digite o segundo valor: ");
            if (!double.TryParse(Console.ReadLine(), out double valor2))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            if (valor1 > valor2)
            {
                Console.WriteLine($"O maior valor é: {valor1}");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine($"O maior valor é: {valor2}");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, ambos são iguais.");
            }
        }
    }
}