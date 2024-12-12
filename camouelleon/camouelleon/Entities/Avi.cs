using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Avi
{
    public int Idavis { get; set; }

    public string Commentaire { get; set; } = null!;

    public DateOnly Datecreation { get; set; }

    public virtual ICollection<Utilisateur> Idutilisateurs { get; set; } = new List<Utilisateur>();
}
