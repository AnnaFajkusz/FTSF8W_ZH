using System;
using System.Collections.Generic;

namespace FTSF8W_ZH.Models;

public partial class Vasarlo
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public string Varos { get; set; } = null!;

    public virtual ICollection<Borshop> Borshops { get; } = new List<Borshop>();
}
