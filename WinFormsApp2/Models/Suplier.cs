using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Suplier
{
    public int Idsuplier { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
