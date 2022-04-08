using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = ConversorDeMoeda.ValorPago(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
