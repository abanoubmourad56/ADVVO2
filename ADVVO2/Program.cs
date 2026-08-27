using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        return products.Where(filter).ToList();
    }

    static void Main()
    {
        List<Product> catalog = new()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }
        };
        var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
        var under50 = SearchProducts(catalog, p => p.Price < 50);
        var inStock = SearchProducts(catalog, p => p.Stock > 0);
        var clothingUnder100 = SearchProducts(
            catalog, p => p.Category == "Clothing" && p.Price < 100);

        //// Task 03 : Custom Report Generator

        //        // 3.1 Print Reports

        //static void PrintReport(List<Product> products, Action<Product> action)
        //        {
        //            foreach (var product in products)
        //            {
        //                action(product);
        //            }
        //        }


        //        // Scenario 1: Short Report
        //        Console.WriteLine("-- Short Report ---");
        //        PrintReport(catalog, p =>
        //        {
        //            Console.WriteLine($"{p.Name} - ${p.Price}");
        //        });


        //        // Scenario 2: Detailed Report
        //        Console.WriteLine("\n-- Detailed Report ---");
        //        PrintReport(catalog, p =>
        //        {
        //            Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");
        //        });

//// 3.2 Transform Products

//static List<string> TransformProducts(
//    List<Product> products,
//    Func<Product, string> transform)
//        {
//            return products.Select(transform).ToList();
//        }


//        // Scenario 3: Summary List

//        Console.WriteLine("-- Summary List ---");

//        var summaryList = TransformProducts(
//            catalog,
//            p => $"{p.Name} (${p.Price})"
//        );

//        foreach (var item in summaryList)
//        {
//            Console.WriteLine(item);
//        }


//        // Scenario 4: Price Label

//        Console.WriteLine("\n-- Price Labels ---");

//        var priceLabels = TransformProducts(
//            catalog,
//            p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}"
//        );

//        foreach (var item in priceLabels)
//        {
//            Console.WriteLine(item);
//        }


    }
}
