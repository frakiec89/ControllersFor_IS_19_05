using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PhoneContext context = new PhoneContext())
            {
                SqlParameter param = new SqlParameter("@price", 58);

                var phones = context.Phones.FromSqlRaw<Phone>("SELECT * FROM GetPhonesByPrice(@price)", param).
                    Include(x=>x.Company).ToList();
               
                foreach (var u in phones)
                    Console.WriteLine($" ID {u.Id} {u.Name} -{u.Price} -  {u.Company.Name} ");
            }
        }
    }
}
