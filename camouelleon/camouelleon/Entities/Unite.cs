using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Unite
{
    public int Idunite { get; set; }

    public string Lblunite { get; set; } = null!;

    public virtual ICollection<Produit> Produits { get; set; } = new List<Produit>();
}
