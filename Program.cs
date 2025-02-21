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
            CBookCard card1 = new CBookCard("Автор", "Название","Издание", 2025, 100, 10);
            Console.WriteLine(card1);
            card1.Rating = 150;
            card1.Commentary = "Комментарий";
            Console.WriteLine(card1);

            Console.ReadKey();
        }
    }
}
