using Newtonsoft.Json;
using System;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Test product", 100.01m, 100, new DateTime (2019, 06, 30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single produut object :");
            Console.WriteLine(json);
            Console.WriteLine(new string ('-', 50));

        }
    }
}
