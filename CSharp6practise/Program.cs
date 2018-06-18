using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp6practise
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem item = new OrderItem();
            WriteLine(item.Count);
            WriteLine(item.ApplyDiscount);
            var products = new Dictionary<string, Product>
            {
                ["H8X"] = new Product { Code="H8B", Name="HTC 8B", UnitPrice=350}
            };
            Console.ReadKey();
        }
    }
}
