using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Model
{
    [Serializable]
    public class Group
    {
        public string Name { get; private set; }
        public DateTime StrartWork { get; private set; }
        public int CounyCurs { get; private set; }

        public Group(string name, DateTime strartWork, int counyCurs)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"\"{nameof(name)}\"Название группы не может быть пустым или содержать только пробел.", nameof(name));
            }


            if (counyCurs <=0)
            {
                throw new ArgumentException($"\"{nameof(counyCurs)}\"кол-во  курсов не  может  быть  отрицательным или рано нулю"
                    , nameof(counyCurs));
            }

            Name = name;
            StrartWork = strartWork;
            CounyCurs = counyCurs;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
