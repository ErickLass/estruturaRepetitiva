using System;
using System.Diagnostics.Contracts;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Programa para fazer raiz quadrada");
        Console.Write("Digite um numero: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0)
        {
            double raiz = Math.Sqrt(x); //raiz quadrada
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro numero: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Numero negativo!");
    }
}