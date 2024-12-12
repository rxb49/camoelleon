using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Attribuer
{
    public int Idcommande { get; set; }

    public int Idproduit { get; set; }

    public int Quantite { get; set; }

    public virtual Commande IdcommandeNavigation { get; set; } = null!;

    public virtual Produit IdproduitNavigation { get; set; } = null!;
}
