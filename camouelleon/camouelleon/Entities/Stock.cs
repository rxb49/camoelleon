using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Stock
{
    public int Idstock { get; set; }

    public string Lblstock { get; set; } = null!;

    public virtual ICollection<Ranger> Rangers { get; set; } = new List<Ranger>();
}
