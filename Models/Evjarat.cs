using System;
using System.Collections.Generic;

namespace FTSF8W_ZH.Models;

public partial class Evjarat
{
    public int Id { get; set; }

    public int Ev { get; set; }

    public virtual ICollection<Borshop> Borshops { get; } = new List<Borshop>();
}
