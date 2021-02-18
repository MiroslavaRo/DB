using System;
using System.Collections.Generic;
using System.Linq;
using task_01.Models;

namespace task_01
{
    class Program
    {
        static ComputerStoreContext cs = new ComputerStoreContext();
        static void Main(string[] args)
        {
            Console.WriteLine("=====Homework=====\n");
             task01();
             task02();
             task03();
             task04();
             task05();
             task06();
             task07();
             task08();
             task09();
             task10();
             task12();
             task14();
             task15();
             task16();
             task17();
            task18();
            task19();
            task20();
            Console.WriteLine("Delete changes?\n1-yes 2-no");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Product product1 = new Product();
                    Product product2 = new Product();
                    var productToRemove =
               from p in cs.Products
               where p.NameProduct == "Loudspeakers"
               where p.Price == 70
               where p.IdManufacture == 2
               select p;
                    foreach (var pr in productToRemove)
                    {
                        product1 = pr;
                        cs.Products.Remove(pr);
                    }
                    var productToUpdate =
                        from prod in cs.Products
                        where prod.IdProduct == 8
                        select prod;
                    foreach(var pro in productToUpdate)
                    {
                        product2 = pro;
                        pro.NameProduct = "LG OLED TV 65";
                        cs.Products.Update(pro);
                    }
                    cs.SaveChanges();
                    if (!cs.Products.Contains(product1)&&product2.NameProduct!= "Laser Printer")
                    {
                        Console.WriteLine("Chages was deleted");
                    }
                    break;
                default:
                    Console.WriteLine("Changes wasn't deleted");                    
                    break;
            }
            Console.WriteLine("\n\tPress enter to finish\n");
            Console.ReadLine();
        }
            static void JustSelect()
            {
                var ListOfProducts = cs.Products.Select(a => new { a.NameProduct, a.Price }).ToList();
                foreach (var p in ListOfProducts)
                {
                    Console.WriteLine($"Name:{p.NameProduct}\t Price: {p.Price} $");
                }
            }
            static void task01()
            {
                Console.WriteLine("1. Select the names of all the products in the store.\n");
                Console.WriteLine("-----Names of products-----\n");
                var query =
                    from product in cs.Products
                    select product;
                foreach (var q in query)
                {
                    Console.WriteLine(q.NameProduct);
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task02()
            {
                Console.WriteLine("2.Select the names and the prices of all the products in the store.\n");
                var query =
                    from product in cs.Products
                    select product;
                foreach (var q in query)
                {
                    Console.WriteLine($"Name: {q.NameProduct}\t Price: {q.Price} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task03()
            {
                Console.WriteLine("3. Select the name of the products with a price less than or equal to $200.\n");
                var query =
                    from product in cs.Products
                    where product.Price <= 200
                    select product;
                foreach (var q in query)
                {
                    Console.WriteLine($"Name: {q.NameProduct}\t Price: {q.Price} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task04()
            {
                Console.WriteLine("4.Select all the products with a price between $60 and $120.\n");
                var ListProducts = cs.Products.Select(a => new { a.NameProduct, a.Price }).Where(a => a.Price >= 60 && a.Price <= 120).ToList();
                foreach (var p in ListProducts)
                {
                    Console.WriteLine($"Name: {p.NameProduct} \t Price: {p.Price} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task05()
            {
                Console.WriteLine("5. Select the name and price in cents (i.e., the price must be multiplied by 100).\n");
                var ListProducts = cs.Products.Select(a => new { a.NameProduct, price = a.Price * 100 }).ToList();
                foreach (var p in ListProducts)
                {
                    Console.WriteLine($"Name: {p.NameProduct} \t Price: {p.price} cents");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task06()
            {
                Console.WriteLine("6. Compute the average price of all the products.\n");
                var Avg = cs.Products.Select(a => a.Price).ToList().Average();
                Console.WriteLine($"Avarage Price: {Math.Round((decimal)Avg):F0} $");
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task07()
            {
                Console.WriteLine("7. Compute the average price of all products with manufacturer code equal to 1.\n");
                var query1 =
                    from product in cs.Products
                    where product.IdManufacture == 1
                    select product.Price;
                var avg = query1.ToArray().Average();
                Console.WriteLine($"Avarage Price: {Math.Round((decimal)avg):F0} $");

                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task08()
            {
                Console.WriteLine("8. Compute the number of products with a price larger than or equal to $180.\n");
                var query1 =
                    from product in cs.Products
                    where product.Price >= 180
                    select product.Price;
                var count = query1.Count();
                Console.WriteLine($"Number of products: {count}");
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task09()
            {
                Console.WriteLine("9. Select the name and price of all products with a price larger than or equal to $180, and sort first by price (in descending order), and then by name (in ascending order).\n");
                var query1 =
                    from product in cs.Products
                    where product.Price >= 180
                    orderby product.Price
                    orderby product.NameProduct ascending
                    select product;
                foreach (var p in query1)
                {
                    Console.WriteLine($"Name: {p.NameProduct} Price: {p.Price} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task10()
            {
                Console.WriteLine("10. Select all the data from the products, including all the data for each product's manufacturer.\n11. Select the product name, price, and manufacturer name of all the products.\n");
                var query =
                    from p in cs.Products
                    join m in cs.Manufactures
                    on p.IdManufacture equals m.IdManufacture into allProducts
                    from man in allProducts.DefaultIfEmpty()
                    select new
                    {
                        Idproduct = p.IdProduct,
                        ProductName = p.NameProduct,
                        Price = p.Price,
                        Idmanuf = man.IdManufacture,
                        ManufName = man == null ? "Unknown" : man.NameManufacture
                    };
                foreach (var q in query)
                {
                    Console.WriteLine($"Product: ID - {q.Idproduct} Name: {q.ProductName} Price = {q.Price} $ Manufacture ID - {q.Idmanuf} Name: {q.ManufName} ");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task12()
            {
                Console.WriteLine($"12. Select the average price of each manufacturer's products, showing only the manufacturer's code.\n13. Select the average price of each manufacturer's products, showing the manufacturer's name.\n");

                var query =
                    from m in cs.Manufactures
                    select new
                    {
                        Id = m.IdManufacture,
                        Name = m.NameManufacture,
                        Avg = (from p in cs.Products
                               where p.IdManufacture == m.IdManufacture
                               select p.Price).ToList()
                    };
                foreach (var q in query)
                {
                    Console.WriteLine($"ID Manufacture: {q.Id} Name: {q.Name}, Average Price: {Math.Round((decimal)q.Avg.Average())} ");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task14()
            {
                Console.WriteLine($"14. Select the names of manufacturer whose products have an average price larger than or equal to $150.\n");
                var query1 =
                    from m in cs.Manufactures
                    select new
                    {
                        Id = m.IdManufacture,
                        Name = m.NameManufacture,
                        Avg = (from p in cs.Products
                               where p.IdManufacture == m.IdManufacture
                               select p.Price).ToList()
                    };
                var query2 =
                    from mn in query1
                    where mn.Avg.Average() >= 150
                    select mn.Name;
                foreach (var q in query2)
                {
                    Console.WriteLine($"Manufacture Name: {q} ");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task15()
            {
                Console.WriteLine($"15. Select the name and price of the cheapest product.\n");
                var query =
                    from p in cs.Products
                    orderby p.Price
                    select new
                    {
                        Name = p.NameProduct,
                        Price = p.Price
                    };
                var Lowest = query.ToList().First();
                Console.WriteLine($"Name: {Lowest.Name} Price: {Lowest.Price} $");
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task16()
            {
                Console.WriteLine("16. Select the name of each manufacturer along with the name and price of its most expensive product.\n");
                var query =
                    from m in cs.Manufactures
                    select new
                    {
                        ManName = m.NameManufacture,
                        Price = (from p in cs.Products
                                 where m.IdManufacture == p.IdManufacture
                                 orderby p.Price descending
                                 select p.Price).ToList(),
                        ProductName = (from p in cs.Products
                                       where m.IdManufacture == p.IdManufacture
                                       orderby p.Price descending
                                       select p.NameProduct).ToList()
                    };
                foreach (var q in query)
                {
                    Console.WriteLine($"Manufacture Name: {q.ManName}, Product Name: {q.ProductName.First()}, Price: {q.Price.First()} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task17()
            {
                Console.WriteLine("17. Select the name of each manufacturer which have an average price above $145 and contain at least 2 different products.\n");
                var query1 =
                   from m in cs.Manufactures
                   select new
                   {
                       Id = m.IdManufacture,
                       Name = m.NameManufacture,
                       Avg = (from p in cs.Products
                              where p.IdManufacture == m.IdManufacture
                              select p.Price).ToList()
                   };
                var query2 =
                    from mn in query1
                    where mn.Avg.Average() <= 145
                    where mn.Avg.Count() > 2
                    select mn.Name;
                foreach (var q in query2)
                {
                    Console.WriteLine($"Manufacture Name: {q} ");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void deletion()
            {
                Product p = new Product();
                var query0 =
                   from product in cs.Products
                   where product.NameProduct == "Loudspeakers"
                   select product;
                foreach (var pr in query0)
                {
                    p = pr;
                }
                if (cs.Products.Contains(p))
                {
                    foreach (var pr in query0)
                    {
                        cs.Products.Remove(pr);

                    }
                }                
                    cs.SaveChanges();                   

            }
            static void task18()
            {
            deletion();
            Console.WriteLine("18. Add a new product: Loudspeakers, $70, manufacturer 2.\n");
                Product p = new Product();
                p.NameProduct = "Loudspeakers";
                p.Price = 70;
                p.IdManufacture = 2;
                cs.Products.Add(p);
                cs.SaveChanges();
                var query =
                    from pr in cs.Products
                    where pr.IdManufacture == 2
                    select pr;
                foreach (var q in query)
                {
                    Console.WriteLine($"ID-{q.IdProduct} Name: {q.NameProduct} Price: {q.Price} $ Manufacture ID-{q.IdManufacture}");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }
            static void task19()
            {
                Console.WriteLine("19. Update the name of product 8 to 'Laser Printer'.\n");

            var query =
                from p in cs.Products
                where p.IdProduct == 8
                select p;
            foreach(var q in query)
            {
                Console.WriteLine("Before Update:");
                Console.WriteLine($"ID-{q.IdProduct} Name: {q.NameProduct}");
                q.NameProduct = "Laser Printer";
                cs.Products.Update(q);
            }            
            cs.SaveChanges();
            Console.WriteLine("-------------------------");
            foreach (var q in query)
            {
                Console.WriteLine("After Update:");
                Console.WriteLine($"ID-{q.IdProduct} Name: {q.NameProduct}");
            }
            Console.WriteLine("\n\tPress enter to continue\n");
            Console.ReadLine();
            }
            static void task20()
            {
                Console.WriteLine("20. Apply a 10% discount to all products.\n");
                var query1 =
                    from p in cs.Products
                    select p;
                Console.WriteLine("Prices without discount:\n");
                foreach (var q in query1)
                {
                    Console.WriteLine($"{q.NameProduct}: {q.Price} $");
                }
                var query2 =
                  from p in cs.Products
                  select new
                  {
                      Name = p.NameProduct,
                      Price = p.Price * 0.9
                  };
                Console.WriteLine("\nPrices with 10% discount:\n");
                foreach (var q in query2)
                {
                    Console.WriteLine($"{q.Name}: {q.Price} $");
                }
                Console.WriteLine("\n\tPress enter to continue\n");
                Console.ReadLine();
            }

        }
    }

