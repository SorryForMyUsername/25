
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software software1 = new Software();
            software1.Name = "Windows 10";
            software1.Manufacturer = "Microsoft";
            software1.IsFree = true;
            Console.WriteLine(software1);
            software1.OppositeIsFreeField();
            Console.WriteLine($"Продукт стал платным!\n{software1}\n");

            Software software2 = new Software("Visual Studio", "Microsoft", true);
            Console.WriteLine($"{software2}\n" +
                $"Продукт бесплатный? {software2.ThisSoftwareIsFree()}\n");

            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Производитель: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Бесплатно/Платно: ");
            bool isFree = Console.ReadLine() == "Бесплатно" ? true : false;
            Software software3 = new Software(name, manufacturer, isFree);
            Console.WriteLine(software3);

            Console.ReadKey(true);
        }
    }
}
