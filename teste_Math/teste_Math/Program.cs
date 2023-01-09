using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadradro, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadradro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadradro;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}