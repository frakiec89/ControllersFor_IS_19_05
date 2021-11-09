using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Model
{
    public class Student : Piople 
    {
        public Group Group { get;  set; }

        #region конструкторы 
        public Student(string name, DateTime dateBythDay , string group) : base(name, dateBythDay)
        {
            if (string.IsNullOrEmpty(group)) 
            {
                throw new ArgumentException($"\"{nameof(group)}\"Имя группы не может быть неопределенным или пустым.", nameof(group));
            }

            Group = GetGroup(group);
        }

        public Student(string name, DateTime dateBythDay, Group group) : base(name, dateBythDay)
        {
            if (group is null)
            {
                throw new ArgumentNullException(nameof(group));
            }
            Group = group;
        }
        #endregion

        /// <summary>
        /// Поиск  группы в  списке 
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        private Group GetGroup(string group)
        {
            throw new NotImplementedException(); // либо  создать новую  , либо  найти из  списка
        }
    }
}
