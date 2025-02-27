using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_2
{
    internal class Software
    {
        /// <summary>
        /// Поле Название
        /// </summary>
        string name;
        /// <summary>
        /// Поле Производитель
        /// </summary>
        string manufacturer;
        /// <summary>
        /// Поле Платно/бесплатно
        /// </summary>
        bool isFree;

        /// <summary>
        /// Свойство Название
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == String.Empty || value == null)
                {
                    name = "Неизвестно";
                }
                else
                {
                    name = value;
                }
            }
        }
        /// <summary>
        /// Свойство Производитель
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if(value == String.Empty || value == null)
                {
                    manufacturer = "Неизвестно";
                }
                else
                {
                    manufacturer = value;
                }
            }
        }
        /// <summary>
        /// Свойство Платно/бесплатно
        /// </summary>
        public bool IsFree
        {
            get
            {
                return isFree;
            }
            set
            {
                isFree = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Software() { }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="manufacturer">Производитель</param>
        /// <param name="isFree">Платно/Бесплатно</param>
        public Software(string name, string manufacturer, bool isFree)
        {
            Name = name;
            Manufacturer = manufacturer;
            IsFree = isFree;
        }

        /// <summary>
        /// Метод, изменяющий поле платное/бесплатное на противоположное.
        /// </summary>
        public void OppositeIsFreeField()
        {
            IsFree = !IsFree;
        }

        /// <summary>
        /// Метод, определяющий является ли данное ПО бесплатным продуктом заданного производителя.
        /// </summary>
        /// <returns>True если данное ПО бесплатно, false если платное</returns>
        public bool ThisSoftwareIsFree()
        {
            return IsFree;
        }

        /// <summary>
        /// Метод, возвращающий значения всех полей объекта в виде строки.
        /// </summary>
        /// <returns>Значения всех полей объекта в виде строки.</returns>
        public override string ToString()
        {
            return $"Название: {Name}\tПроизводитель: {Manufacturer}\tБесплатно: {(IsFree ? "Да" : "Нет")}";
        }
    }
}
