using Linq;
using System.Collections;
using System.Collections.Generic;

List<Product> products = new List<Product>
            {
                new Product{ProductId = 1 , Name = "Laptop" , Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { ProductId = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 5 },
                new Product { ProductId = 3, Name = "Book", Category = "Books", Price = 20, Stock = 50 },
                new Product { ProductId = 4, Name = "Table", Category = "Furniture", Price = 100, Stock = 3 }
            };

List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, ProductId = 1, Quantity = 2, OrderDate = DateTime.Now.AddDays(-3) },
                new Order { OrderId = 2, CustomerId = 2, ProductId = 3, Quantity = 5, OrderDate = DateTime.Now.AddDays(-10) },
                new Order { OrderId = 3, CustomerId = 1, ProductId = 2, Quantity = 1, OrderDate = DateTime.Now.AddDays(-1) }
            };

List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId = 1, Name = "Ali" },
                new Customer { CustomerId = 2, Name = "Veli" }
            };


//1)
//var result = from c in products
//             where c.Category == "Electronics" 
//             select c; 

//foreach (var item in result)
//{
//    Console.WriteLine($"Name:{item.Name} Price:{item.Price} Stock:{item.Stock}");
//}


//2)
//var result = (from c in products
//              select c.Price * c.Stock).Sum();
//Console.WriteLine(result);


//3)
//var result = from c in customers
//             join p in products
//             on c.CustomerId equals p.ProductId
//             select new
//             {
//                 Customer_Name = c.Name,
//                 Product_name = p.Name,
//             };

//foreach (var item in result)
//{
//    Console.WriteLine($"Customer Name:{item.Customer_Name} Product Name:{item.Product_name}");
//}


//4)
//var result = (from o in orders
//              group o by o.ProductId into g
//              orderby g.Sum(x => x.Quantity) descending
//              select new
//              {
//                  ProductId = g.Key,
//                  Quantity = g.Sum(x => x.Quantity)
//              }).FirstOrDefault();

//var productName = products.FirstOrDefault(p => p.ProductId == result.ProductId).Name;
//Console.WriteLine($"Most ordered product: {productName}, Quantity: {result.Quantity}");


//5)
//var result = from o in orders
//             where o.OrderDate >= DateTime.Now.AddDays(-7).Date
//             select new
//             {
//                 orderId = o.OrderId,
//                 orderDate = o.OrderDate
//             };

//foreach (var item in result)
//{
//    Console.WriteLine($"Order Id:{item.orderId} , Order date:{item.orderDate}");
//}


//6)
//var result = from p in products
//             where p.Stock < 5
//             select p;

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}


//7)
//var groupedProducts = from p in products
//                      group p by p.Category into categoryGroup
//                      select new
//                      {
//                          Category = categoryGroup.Key,
//                          ProductCount = categoryGroup.Count()
//                      };

//foreach (var group in groupedProducts)
//{
//    Console.WriteLine($"category: {group.Category}, Product count: {group.ProductCount}");
//}


//8)
//var customerStatistics = from o in orders
//                         group o by o.CustomerId into customerGroup
//                         select new
//                         {
//                             CustomerId = customerGroup.Key,
//                             OrderCount = customerGroup.Count(),
//                             TotalQuantity = customerGroup.Sum(x => x.Quantity)
//                         };

//foreach (var item in customerStatistics)
//{
//    Console.WriteLine($"Customer ID: {item.CustomerId}, Order count: {item.OrderCount}, Total: {item.TotalQuantity}");
//}



//9
//var result = (from p in products
//              group p by p.Price into g
//              orderby g.Key descending
//              select g.FirstOrDefault()).FirstOrDefault();

//Console.WriteLine($"Product Name: {result.Name}, Price: {result.Price}");



