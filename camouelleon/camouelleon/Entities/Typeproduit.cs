using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Typeproduit
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public virtual ICollection<Produit> Produits { get; set; } = new List<Produit>();
}
