using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Table
{
    public int Idtable { get; set; }

    public int Idzone { get; set; }

    public int Nbplace { get; set; }

    public short Estlibre { get; set; }

    public virtual Zone IdzoneNavigation { get; set; } = null!;

    public virtual ICollection<Commande> Idcommandes { get; set; } = new List<Commande>();

    public virtual ICollection<Reservation> Idreservations { get; set; } = new List<Reservation>();
}
