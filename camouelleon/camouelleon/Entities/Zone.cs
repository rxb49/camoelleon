using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Zone
{
    public int Idzone { get; set; }

    public string Lblzone { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
