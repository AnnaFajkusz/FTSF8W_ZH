using System;
using System.Collections.Generic;

namespace FTSF8W_ZH.Models;

public partial class Ar
{
    public int Id { get; set; }

    public int Ft { get; set; }

    public virtual ICollection<Borshop> Borshops { get; } = new List<Borshop>();
}
