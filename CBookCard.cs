using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_2
{
    internal class CBookCard
    {
        string author;
        string title;
        string publicationHouse;
        int publicationYear;
        int pages;
        int printing;
        int rating;
        string commentary;

        public string Author
        {
            get
            {
                if(author == null || author == "") {
                    return "Неизвестный";
                }
                return author;
            }
            set => author = value; }
        public string Title {
            get
            {
                if (title == null || title == "")
                {
                    return "Неизвестный";
                }
                return title;
            }
            set => title = value; }
        public string PublicationHouse {
            get
            {
                if (publicationHouse == null || publicationHouse == "")
                {
                    return "Неизвестный";
                }
                return publicationHouse;
            }
            set => publicationHouse = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Printing { get => printing; set => printing = value; }
        public int Rating { get => rating;
            set
            {
                if(value < 0) rating = 0;
                else if(value > 100) rating = 100;
                else rating = value;
            }
        }
        public string Commentary { get => commentary; set => commentary = value; }
        public int PublicationYear { get => publicationYear; 
            set
            {
                if (value < 1990) publicationYear = 1990;
                else if (value > 2025) publicationYear = 2025;
                else publicationYear = value;
            }
        }

        public CBookCard() { }

        public CBookCard(string author, string title, string publicationHouse, int publicationYear, int pages, int printing)
        {
            Author = author;
            Title = title;
            PublicationHouse = publicationHouse;
            PublicationYear = publicationYear;
            Pages = pages;
            Printing = printing;
            Rating = 0;
            Commentary = string.Empty;
        }

        public override string ToString()
        {
            return $"Автор: {Author}\tЗаглавие: {Title}\tИздательство: {PublicationHouse}\tГод издания: {PublicationYear}\tЧисло страниц: {Pages}\tТираж: {Printing}\tРейтинг: {Rating}\tКомментарий: {Commentary}";
        }
    }
}
