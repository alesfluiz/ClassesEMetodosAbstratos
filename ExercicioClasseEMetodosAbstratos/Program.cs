using System;
using ExercicioClasseEMetodosAbstratos.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioClasseEMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healtexpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployee));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPayer taxPlayer in list)
            {
                Console.WriteLine(taxPlayer);                               
                sum += taxPlayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}