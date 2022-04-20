using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double values = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double valueIndividual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            
        }
    }
}
