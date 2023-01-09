using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double A, B, Media;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Media = (A + B) / 2;

        Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));

    }

}