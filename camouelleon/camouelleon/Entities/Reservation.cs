using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Reservation
{
    public int Idreservation { get; set; }

    public int Idutilisateur { get; set; }

    public DateTime Datedebutreservation { get; set; }

    public DateTime? Datefinreservation { get; set; }

    public short? Annulation { get; set; }

    public int? Nbpersonne { get; set; }

    public short? Confirmee { get; set; }

    public virtual Utilisateur IdutilisateurNavigation { get; set; } = null!;

    public virtual ICollection<Table> Idtables { get; set; } = new List<Table>();
}
