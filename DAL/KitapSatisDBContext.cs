using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class KitapSatisDBContext : IdentityDbContext<IdentityUser>
    {
        public KitapSatisDBContext()
        {
            
        }
        public KitapSatisDBContext(DbContextOptions<KitapSatisDBContext> options) : base(options) { }
        
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Data source=Samet\\SQLEXPRESS;initial catalog=KitapSatisDBContext;integrated security=true;trust server certificate=true");
        }
    }
}
