using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Publication
    {
        /// <summary>
        /// Поле Название
        /// </summary>
        string title;
        /// <summary>
        /// Поле Фамилия автора
        /// </summary>
        string author_surname;
        /// <summary>
        /// Поле Год издания
        /// </summary>
        int publicationYear;

        /// <summary>
        /// Свойство Название
        /// </summary>
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
        /// <summary>
        /// Свойство Фамилия автора
        /// </summary>
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
        /// <summary>
        /// Свойство Год издания
        /// </summary>
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

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Publication() { }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author_surname">Фамилия автора</param>
        /// <param name="publicationYear">Год издания</param>
        public Publication(string title, string author_surname, int publicationYear)
        {
            Title = title;
            Author_surname = author_surname;
            PublicationYear = publicationYear;
        }

        /// <summary>
        /// Метод, изменяющий год издания.
        /// </summary>
        /// <param name="addedYears">Кол-во лет, на которое увеличится год издания</param>
        public void ChangePublicationYear(int addedYears)
        {
            PublicationYear += addedYears;
        }

        /// <summary>
        /// Метод, определяющий попадает ли год издания в заданный интервал.
        /// </summary>
        /// <param name="from">С какого года начинается интервал</param>
        /// <param name="to">В каком году заканчивается интервал</param>
        /// <returns>True если год издания попадает в интервал, иначе false</returns>
        public bool IsPublicationYearInRange(int from, int to)
        {
            return (PublicationYear >= from && PublicationYear <= to);
        }

        /// <summary>
        /// Метод, возвращающий значения всех полей объекта в виде строки.
        /// </summary>
        /// <returns>Все поля объекта в виде строки.</returns>
        public override string ToString()
        {
            return $"Название: {Title}\tФамилия автора: {Author_surname}\tГод издания: {PublicationYear}";
        }
    }
}
