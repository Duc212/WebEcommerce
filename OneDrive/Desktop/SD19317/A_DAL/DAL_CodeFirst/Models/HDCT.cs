
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Models
{
    public class HDCT
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(SanPham))]// Xac dinh khoa ngoai noi voi bang San Pham
        public int? Idsp { get; set; }
        [ForeignKey(nameof(HoaDon))] // Xac dinh khoa ngoai voi bang hoa Don
        public int? Idhd { get; set; }

        public decimal? Gia { get; set; }

        public int? Soluong { get; set; }

        public int? Trangthai { get; set; }
        //navigation
        public virtual HoaDon HoaDon { get; set; } // 1 HDCT chi nam trong 1 HD
        public virtual SanPham SanPham { get; set; } // 1 HDCT chi chua 1 san pham duy nhat
    }
}
