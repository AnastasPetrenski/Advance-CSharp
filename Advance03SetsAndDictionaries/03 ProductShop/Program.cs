using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopProducts = new Dictionary<string, Dictionary<string, double>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] shopInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = shopInfo[0];
                string product = shopInfo[1];
                double price = double.Parse(shopInfo[2]);

                if (!shopProducts.ContainsKey(shop))
                {
                    shopProducts.Add(shop, new Dictionary<string, double>());
                }

                if (shopProducts[shop].ContainsKey(product))
                {
                    shopProducts[shop].Add(product, 0);
                }

                shopProducts[shop][product] = price;
            }

            foreach (var (shop, products) in shopProducts.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop}->");
                foreach (var item in products)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
