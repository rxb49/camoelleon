using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Allergie
{
    public int Idallergie { get; set; }

    public string Lblallergie { get; set; } = null!;

    public virtual ICollection<Produit> Idproduits { get; set; } = new List<Produit>();
}
