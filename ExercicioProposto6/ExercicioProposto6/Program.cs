using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Estudante[] vect = new Estudante[10];


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[room] = new Estudante(name, email);

            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
