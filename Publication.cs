using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Publication
    {
        string title;
        string author_surname;
        int publicationYear;

        public string Title {
            get { 
                if(title == null || title == "")
                {
                    return "неизвестный";
                }
                return title;
            } 
            set { title = value; }
        }
        public string Author_surname { 
            get {
                if (author_surname == null || author_surname == "")
                {
                    return "неизвестный";
                }
                return author_surname;
            } 
            set { author_surname = value; }
        }
        public int PublicationYear {
            get {
                return publicationYear;
            }
            set { 
                if(publicationYear < 1990 && publicationYear != 0)
                {
                    publicationYear = 1990;
                }
                else if(publicationYear > 2024)
                {
                    publicationYear = 2024;
                }
                else
                {
                    publicationYear = value;
                }
            }
        }

        public Publication() { }

        public Publication(string title, string author_surname, int publicationYear)
        {
            Title = title;
            Author_surname = author_surname;
            PublicationYear = publicationYear;
        }

        public void ChangePublicationYear(int addedYears)
        {
            PublicationYear += addedYears;
        }

        public bool IsPublicationYearInRange(int from, int to)
        {
            return (PublicationYear >= from && PublicationYear <= to);
        }

        public override string ToString()
        {
            return $"Название: {Title}\tФамилия автора: {Author_surname}\tГод издания: {PublicationYear}";
        }
    }
}
