using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Számla.Models;

namespace Számla.Data
{
    public class context : DbContext
    {
        public context() { }

        public DbSet<Class1> Class1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string connMySql = "Server=127.0.0.1;UserID=root@localhost;Password=;Database=Class1";
             optionsBuilder.UseSqlServer(connMySql);

           // string connMSsql = ("Server=(localdb)\\MSSQLLocalDB;Database=AllatkakDB;Trusted_Connection=True;");
           // optionsBuilder.UseSqlServer(connMSsql);
        }
    }
}
