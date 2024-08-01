using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public decimal? TongTien { get; set; }

    public string? Mota { get; set; }

    public int? Trangthai { get; set; }

    public virtual ICollection<Hdct> Hdcts { get; set; } = new List<Hdct>();
}
