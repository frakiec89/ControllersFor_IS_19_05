using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Model
{
    public class Piople
    {
        #region поля
        public string Name { get; private set; } // инкапсулирование
        public DateTime DateBythDay { get; private set; }// инкапсулирование
        #endregion

        #region конструкторы
        public Piople(string name, DateTime dateBythDay)
        {
            #region проверки параметров
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException
                    ($"\"{nameof(name)}\"Имя не  может быть неопределенным или пустым.",
                    nameof(name));
            }
            if (dateBythDay > DateTime.Now)
            {
                throw new ArgumentException
                       ($"\"{nameof(dateBythDay)}\"Дата рождения не может быть больше сегодняшнего числа",
                       nameof(DateBythDay));
            }
            #endregion
            Name = name;
            DateBythDay = dateBythDay;
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
