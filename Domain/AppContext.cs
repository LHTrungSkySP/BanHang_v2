using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AppContext: DbContext
    {
        public const string ConnectStrring = @"Data Source=.;Initial Catalog=BanHang_v2;Integrated Security=True;Encrypt=False;";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectStrring);
        }
    }
}
