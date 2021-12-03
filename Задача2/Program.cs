using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.IO;

namespace Задача2
{

    /* Задача2.   Необходимо разработать программу для получения информации о товаре из json-файла.
Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара
  */
    class Program
    {
        static void Main(string[] args)


        {


            string jsonString = File.ReadAllText(@"C:\Users\Admin\Desktop 2\ИТМО домашние задания\Задача16\Задача16\bin\Debug\Products.json");
            Console.WriteLine(jsonString);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            double max = 0;
            string name = "";
            for (int i = 0; i < 5; i++)
            {
                if (products[i].ProductSale > max)
                {
                    max = products[i].ProductSale;
                    name = products[i].ProductName;
                }


            }

            
            Console.WriteLine(max);

            Console.WriteLine(name);

            Console.ReadKey();


        }
    }

    class Product
    {
        public int ProductCode { get; set; }

        public string ProductName { get; set; }

        public double ProductSale { get; set; }
    }
}
