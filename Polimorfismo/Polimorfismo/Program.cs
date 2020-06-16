﻿using System;
using System.Collections.Generic;
using Polimorfismo.Entities;
using System.Globalization;
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(opcao == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                }if (opcao == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
