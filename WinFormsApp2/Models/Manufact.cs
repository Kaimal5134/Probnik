using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Manufact
{
    public int Idmanufact { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
