using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class PhoneContext : DbContext
    {
        public PhoneContext() 
        { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Phone> Phones { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.10.134;Database=zzzzz;User Id=Sa;Password=Frakiec89"); 
        }

    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
