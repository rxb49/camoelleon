using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Ranger
{
    public int Idstock { get; set; }

    public int Idproduit { get; set; }

    public int? Quantite { get; set; }

    public virtual Produit IdproduitNavigation { get; set; } = null!;

    public virtual Stock IdstockNavigation { get; set; } = null!;
}
