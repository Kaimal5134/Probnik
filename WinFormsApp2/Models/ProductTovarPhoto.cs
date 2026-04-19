using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class ProductTovarPhoto
{
    public int IdproductTovarPhoto { get; set; }

    public byte[] Photo { get; set; } = null!;
}
