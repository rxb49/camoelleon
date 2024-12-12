using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Dechet
{
    public DateOnly Datejeter { get; set; }

    public int Iddechet { get; set; }

    public int Quantite { get; set; }

    public virtual ICollection<Produit> Idproduits { get; set; } = new List<Produit>();
}
