using System;
using System.Collections.Generic;

namespace FTSF8W_ZH.Models;

public partial class Borshop
{
    public int Id { get; set; }

    public string Marka { get; set; } = null!;

    public string Tipus { get; set; } = null!;

    public int Evjaratid { get; set; }

    public DateTime Vasarlasidopont { get; set; }

    public int Vasarloid { get; set; }

    public int Arid { get; set; }

    public virtual Ar Ar { get; set; } = null!;

    public virtual Evjarat Evjarat { get; set; } = null!;

    public virtual Vasarlo Vasarlo { get; set; } = null!;
}
