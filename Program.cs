using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publication publication1 = new Publication();
            publication1.PublicationYear = 2002;
            publication1.Author_surname = "Фамилия";
            publication1.Title = "Публикация";
            Console.WriteLine(publication1);

            Publication publication2 = new Publication("Внимание", "Шичкин", 2023);
            Console.WriteLine(publication2);
            int from = 2000;
            int to = 2010;
            Console.WriteLine($"Публикация с годом издания {publication2.PublicationYear} входит в диапазон от {from} до {to}? " +
                publication2.IsPublicationYearInRange(from, to));
            publication2.ChangePublicationYear(-15);
            Console.Write($"Публикация с годом издания {publication2.PublicationYear} входит в диапазон от {from} до {to}? " +
                publication2.IsPublicationYearInRange(from, to));

            Console.ReadKey();
        }
    }
}
