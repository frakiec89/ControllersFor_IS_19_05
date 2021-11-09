using ConsoleApp10.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Controllers
{
    public class GroupController
    {
        public List<Group> Groups { get; set; }

        public GroupController()
        {
            Groups = Run();
        }

        /// <summary>
        /// подгружает список групп из файла
        /// </summary>
        /// <returns></returns>
        private List<Group> Run()
        {
            var binFormatter = new BinaryFormatter();

            using (var fille = new FileStream("groups1.bin", FileMode.OpenOrCreate))
            {
                try
                {
                    var newGroups = binFormatter.Deserialize(fille);
                    if (newGroups != null)
                    {
                        return newGroups as List<Group>;
                    }
                    else
                    {
                        return new List<Group>();
                    }
                }
                catch
                {
                    return new List<Group>();
                }
            }
        }

         public  void AddGroup ( string name , DateTime date , int count)
         {
            try
            {
                Group group = new Group(name, date, count);

                if( Groups.Where(x=>x.Name == group.Name).ToList().Count>0)
                {
                    return;
                }
                Groups.Add(group);
                Save();
            }
            catch ( Exception ex)
            {
                throw new Exception(ex.Message);
            }
         }

        public Group GetGroup (string name)
        {
         return   Groups.Where(x => x.Name == name).FirstOrDefault();
        }


        /// <summary>
        /// Сохраняет  объект в  файл
        /// </summary>
        public  void Save ()
        {
            var binFormatter = new BinaryFormatter();
            using (var fille = new FileStream("groups1.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fille, Groups);
            }
        }


        public void  RemoveGroup(string name)
        {
            var gr = GetGroup(name);

            if (gr!= null)
            {
                Groups.Remove(gr);
                Save();
            }
        }

    }
}
