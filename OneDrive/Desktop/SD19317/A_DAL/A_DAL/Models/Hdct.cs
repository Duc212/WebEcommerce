using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Hdct
{
    public int Id { get; set; }

    public int? Idsp { get; set; }

    public int? Idhd { get; set; }

    public decimal? Gia { get; set; }

    public int? Soluong { get; set; }

    public int? Trangthai { get; set; }

    public virtual HoaDon? IdhdNavigation { get; set; }

    public virtual SanPham? IdspNavigation { get; set; }
}
