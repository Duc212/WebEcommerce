using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Models
{
    public class AppDbContext : DbContext
    {
        // Tao constructor public

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options) // Constructor ke Thua
        {

        }
        // Khai vao cac DbSet - Moi DbSet se dai dien cho 1 bang o trong DB\
        public DbSet<HoaDon> HoaDons { get; set; }  
        public DbSet<SanPham> SanPhams { get; set; }    
        public DbSet<HDCT> HDCTs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Cau Hinh Lien Ket
        {
            //Sang Ben DBFirst copy ve xong sua ten DB la Xong
            optionsBuilder.UseSqlServer("Server=DUYDUC;Database=Code_first2;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Cau hinh cac Bang
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
