using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class OrderItem
{
    public int IdorderItems { get; set; }

    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int KolVo { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
