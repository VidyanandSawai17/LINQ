using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> productlist = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Company="",Price=999},
                new Product{Id=2,Name="Pen",Company="",Price=20},
                new Product{Id=3,Name="Pencil",Company="",Price=15},
                new Product{Id=4,Name="Marker",Company="",Price=25},
                new Product{Id=5,Name="Keyboard",Company="",Price=859},
                new Product{Id=6,Name="Notebook",Company = "",Price=49},
            };

            //var result=from p in productlist select p;
            //var result = from p in productlist
            //             where p.Price < 50
            //             select p;
            //var result = from p in productlist
            //             where p.Price > 10 && p.Price <30
            //             select p;
            //var result = from p in productlist
            //             where p.Name.Contains("Pe")
            //             select p;
            //var result = from p in productlist
            //             where p.Name.StartsWith("P")
            //             select p;
            //var result = from p in productlist
            //             where p.Name.EndsWith("r")
            //             select p;
            //var result = from p in productlist
            //             where p.Price < 50
            //             orderby p.Name ascending
            //             select p;


            // 1. Display all products using LINQ query:

            var allProducts = from p in productlist
                              select p;

            // 2. Display products whose price is greater than 1500:

            var expensiveProducts = from p in productlist
                                    where p.Price > 1500
                                    select p;

            // 3. Display products whose price is in between 10000 to 40000:

            var mediumPricedProducts = from p in productlist
                                       where p.Price >= 10000 && p.Price <= 40000
                                       select p;


            // 4. Display products of Dell company:

            var dellProducts = from p in productlist
                               where p.Company == "Dell"
                               select p;

            // 5. Display all company laptops:

            var laptops = from p in productlist
                          where p.Name == "Laptop"
                          select p;


            // 6. Display products whose company name start with ‘M’:

            var mCompanyProducts = from p in productlist
                                   where p.Company.StartsWith("M")
                                   select p;


            // 7. Display all company mouse whose price is less than 1000:

            var cheapMice = from p in productlist
                            where p.Name == "Mouse" && p.Price < 1000
                            select p;


            // 8. Display all products descending order by their price:

            var descendingProducts = from p in productlist
                                     orderby p.Price descending
                                     select p;


            // 9. Display all products accessing order by their company name:

            var orderedByCompany = from p in productlist
                                   orderby p.Company
                                   select p;

            // 10. Display all keyboards accessing order by their price:

            var orderedKeyboards = from p in productlist
                                   where p.Name == "Keyboard"
                                   orderby p.Price
                                   select p;

            foreach (Product p in orderedKeyboards)
            {
                Console.WriteLine(p);
            }
        }
    }
}
