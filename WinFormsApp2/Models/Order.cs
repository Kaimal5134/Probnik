using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Order
{
    public int Idzakaz { get; set; }

    public string Article { get; set; } = null!;

    public int Fio { get; set; }

    public int IdStatus { get; set; }

    public string Adrec { get; set; } = null!;

    public DateOnly DataStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public virtual User FioNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
