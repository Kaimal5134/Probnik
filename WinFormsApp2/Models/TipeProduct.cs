using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class TipeProduct
{
    public int IdtipeProduct { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
