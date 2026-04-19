using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class User
{
    public int Iduser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public int IdRole { get; set; }

    public string Email { get; set; } = null!;

    public long Phone { get; set; }

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
