using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Etat
{
    public int Idetat { get; set; }

    public string Lbletat { get; set; } = null!;

    public virtual ICollection<Lier> Liers { get; set; } = new List<Lier>();
}
