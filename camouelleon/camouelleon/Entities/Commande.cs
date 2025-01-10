using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Commande
{
    public int Idcommande { get; set; }

    public int Nbclient { get; set; }

    public virtual ICollection<Attribuer> Attribuers { get; set; } = new List<Attribuer>();

    public virtual ICollection<Facture> Factures { get; set; } = new List<Facture>();

    public virtual ICollection<Lier> Liers { get; set; } = new List<Lier>();

    public virtual ICollection<Table> Idtables { get; set; } = new List<Table>();


}
