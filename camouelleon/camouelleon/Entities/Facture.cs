using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Facture
{
    public int Idfacture { get; set; }

    public int Idcommande { get; set; }

    public int Tva { get; set; }

    public int? Acompte { get; set; }

    public int? Montant { get; set; }

    public int? Montantpaye { get; set; }

    public virtual Commande IdcommandeNavigation { get; set; } = null!;
}
