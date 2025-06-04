using System;
using System.Collections.Generic;
using System.Linq;

class Exercise23
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; } // e.g. Food, Drink, Care, Other
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
    }

    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Bread", UnitPrice = 15, Category = "Food" },
            new Product { ProductId = 2, Name = "Milk", UnitPrice = 8, Category = "Drink" },
            new Product { ProductId = 3, Name = "Soap", UnitPrice = 12, Category = "Care" },
            new Product { ProductId = 4, Name = "Wine", UnitPrice = 55, Category = "Drink" },
            new Product { ProductId = 5, Name = "Notebook", UnitPrice = 9, Category = "Other" }
        };

        var customers = new List<Customer>
        {
            new Customer { CustomerId = 1, CustomerName = "Alice", Country = "Romania", City = "Cluj", Phone = "0723 456 789" },
            new Customer { CustomerId = 2, CustomerName = "Bob", Country = "UK", City = "London", Phone = "0711 222 333" },
            new Customer { CustomerId = 3, CustomerName = "Charlie", Country = "Germany", City = "Berlin", Phone = "0733 444 555" }
        };

        var orders = new List<Order>
        {
            new Order { OrderId = 1, OrderDate = new DateTime(2021, 5, 10), CustomerId = 1 },
            new Order { OrderId = 2, OrderDate = new DateTime(2020, 8, 15), CustomerId = 2 },
            new Order { OrderId = 3, OrderDate = new DateTime(2021, 12, 20), CustomerId = 3 }
        };

        var orderDetails = new List<OrderDetails>
        {
            new OrderDetails { OrderId = 1, ProductId = 1, Quantity = 2 },
            new OrderDetails { OrderId = 1, ProductId = 3, Quantity = 1 },
            new OrderDetails { OrderId = 2, ProductId = 2, Quantity = 5 },
            new OrderDetails { OrderId = 3, ProductId = 4, Quantity = 1 },
            new OrderDetails { OrderId = 3, ProductId = 5, Quantity = 3 }
        };

        var productsOver10 = products.Where(p => p.UnitPrice >= 10);
        var productNames = products.Select(p => p.Name);
        var productInfoOver10 = products.Where(p => p.UnitPrice >= 10)
                                        .Select(p => new { p.Name, p.UnitPrice });
        var twoMostExpensive = products.OrderByDescending(p => p.UnitPrice).Take(2);
        var allButTwoExpensive = products.OrderByDescending(p => p.UnitPrice).Skip(2);

        var customersWithOrders = customers.Join(orders, c => c.CustomerId, o => o.CustomerId,
            (c, o) => new { c.CustomerName, o.OrderId, o.OrderDate });

        var productsByCategoryAndPrice = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
        var groupedProducts = products.GroupBy(p => p.Category);

        var customersWithOrdersIn2021 = customers
            .Where(c => orders.Any(o => o.CustomerId == c.CustomerId && o.OrderDate.Year == 2021));

        var customerByPhone = customers.FirstOrDefault(c => c.Phone == "0723 456 789");
        var customersFromLondon = customers.Count(c => c.City == "London");
        var isCustomerFromRomania = customers.Any(c => c.Country == "Romania");

        var ordersFrom2021 = orders.Where(o => o.OrderDate.Year == 2021)
                                   .Join(orderDetails, o => o.OrderId, od => od.OrderId, (o, od) => new { od.ProductId, od.Quantity })
                                   .Join(products, od => od.ProductId, p => p.ProductId, (od, p) => od.Quantity * p.UnitPrice)
                                   .Sum();

        Console.WriteLine("Products with Unit Price >= 10:");
        foreach (var p in productsOver10)
            Console.WriteLine($"{p.Name} - {p.UnitPrice}");

        Console.WriteLine("\nProduct Names:");
        foreach (var name in productNames)
            Console.WriteLine(name);

        Console.WriteLine("\nProducts (Price >= 10):");
        foreach (var p in productInfoOver10)
            Console.WriteLine($"{p.Name} - {p.UnitPrice}");

        Console.WriteLine("\nMost 2 Expensive Products:");
        foreach (var p in twoMostExpensive)
            Console.WriteLine($"{p.Name} - {p.UnitPrice}");

        Console.WriteLine("\nAll but most 2 Expensive Products:");
        foreach (var p in allButTwoExpensive)
            Console.WriteLine($"{p.Name} - {p.UnitPrice}");

        Console.WriteLine("\nCustomers with their Orders:");
        foreach (var item in customersWithOrders)
            Console.WriteLine($"{item.CustomerName} ordered on {item.OrderDate.ToShortDateString()}");

        Console.WriteLine("\nProducts by Category and Price:");
        foreach (var p in productsByCategoryAndPrice)
            Console.WriteLine($"{p.Category} - {p.Name} - {p.UnitPrice}");

        Console.WriteLine("\nGrouped Products:");
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var p in group)
                Console.WriteLine($" - {p.Name}");
        }

        Console.WriteLine("\nCustomers with Orders in 2021:");
        foreach (var c in customersWithOrdersIn2021)
            Console.WriteLine(c.CustomerName);

        Console.WriteLine($"\nFirst customer with phone '0723 456 789': {(customerByPhone != null ? customerByPhone.CustomerName : "Not found")}");
        Console.WriteLine($"Total customers from London: {customersFromLondon}");
        Console.WriteLine($"Any customer from Romania: {isCustomerFromRomania}");
        Console.WriteLine($"Total sum of orders from 2021: {ordersFrom2021}");
    }
}
