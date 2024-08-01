using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }

        public string Ten { get; set; } = null!;

        public decimal? Gia { get; set; }

        public int? Soluong { get; set; }

        public string? Mota { get; set; }

        public int? Trangthai { get; set; }
        
        // Navigation => The hien lien ket voi cac bang lien quan
        public virtual List<HDCT> HDCTs { get; set; }   

    }
}
