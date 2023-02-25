using GlazAlmaz.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models
{
    public class Repository : DbContext
    {
        public static Repository Instance
        {
            get
            {
                return _instance ??= new Repository();
            }
        }

        private static Repository _instance;

        internal static User LocalUser { get; set; }

        public Repository() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=cfif31.ru;user=ISPr22-32_KalininAV;password=ISPr22-32_KalininAV;database=ISPr22-32_KalininAV_GlazAlmaz",
                new MySqlServerVersion(new Version(8, 0, 32)));
        }

        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Postavshik> Postavshiks { get; set; }
        public DbSet<Zakaz> Zakazs { get; set; }
    }
}
