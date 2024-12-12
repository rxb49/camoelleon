using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Reaprovisionnement
{
    public int Idreaprovisionnement { get; set; }

    public DateOnly Datereaprovisionnement { get; set; }

    public virtual ICollection<Reaprovisionner> Reaprovisionners { get; set; } = new List<Reaprovisionner>();
}
