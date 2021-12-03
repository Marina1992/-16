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

namespace Задача16
{
    /* Задача1.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».

  */
    class Program
    {
        static void Main(string[] args)
        {
            
            Product[] products = new Product[5];

            for (int i = 0; i < 5; i++)
            {
                products[i] = new Product();

                

                Console.WriteLine($"Введите код для {i + 1}-го товара:");

                products[i].ProductCode = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(products[i].ProductCode);

                Console.WriteLine($"Введите название для {i + 1}-го товара:");

                products[i].ProductName = Console.ReadLine();

                Console.WriteLine(products[i].ProductName);

                Console.WriteLine($"Введите  цену товара   для {i + 1}-го товара:");

                products[i].ProductSale = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(products[i].ProductSale);







            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            }; // русский язык 


            string jsonString = JsonSerializer.Serialize(products, options);

            

            Console.WriteLine(jsonString);
            
            System.IO.File.WriteAllText("Products.json", jsonString);
            
                       

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
