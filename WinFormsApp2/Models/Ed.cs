using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Ed
{
    public int Ided { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
