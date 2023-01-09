using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            String nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura ( na mesma linha): ");


            Console.WriteLine(nomeCompleto);
            Console.WriteLine(numQuartos);
            Console.WriteLine(valorProduto);


        }
    }
}