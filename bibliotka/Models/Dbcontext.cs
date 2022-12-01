using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Models
{
    internal class Dbcontext : DbContext
    {
        public DbSet<Kniga> Knigas { get; set; }
        public DbSet<KnigiMqsto> KnigiMqstos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder Sazdaii) =>
            Sazdaii.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bibliotka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
