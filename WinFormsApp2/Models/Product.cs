using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Product
{
    public int Idproduct { get; set; }

    public string Articl { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdTipeProduct { get; set; }

    public string ProductContent { get; set; } = null!;

    public int IdManufactur { get; set; }

    public int IdSuplier { get; set; }

    public decimal PriceProduct { get; set; }

    public int? Sale { get; set; }

    public int? KolVo { get; set; }

    public int IdEd { get; set; }

    public byte[]? IdPhoto { get; set; }

    public virtual Ed IdEdNavigation { get; set; } = null!;

    public virtual Manufact IdManufacturNavigation { get; set; } = null!;

    public virtual Suplier IdSuplierNavigation { get; set; } = null!;

    public virtual TipeProduct IdTipeProductNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
