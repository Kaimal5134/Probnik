using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
