using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Reaprovisionner
{
    public int Idreaprovisionnement { get; set; }

    public int Idproduit { get; set; }

    public int Quantite { get; set; }

    public virtual Produit IdproduitNavigation { get; set; } = null!;

    public virtual Reaprovisionnement IdreaprovisionnementNavigation { get; set; } = null!;
}
