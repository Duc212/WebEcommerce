using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Models
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }

        public decimal? TongTien { get; set; }

        public string? Mota { get; set; }

        public int? Trangthai { get; set; }
        
        //Navigation

        public virtual List<HDCT>HDCTs { get; set; } // Lazy Loading
    }
}
