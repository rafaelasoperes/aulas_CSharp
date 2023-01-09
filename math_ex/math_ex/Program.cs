using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double n, area, raio;

        n = 3.14159;
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        area = n * (Math.Pow(raio, 2.0));

        Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
    }

}