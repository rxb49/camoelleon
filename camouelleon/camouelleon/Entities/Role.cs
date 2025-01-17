using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Role
{
    public int Idrole { get; set; }

    public string Lblrole { get; set; } = null!;

    public virtual ICollection<Utilisateur> Utilisateurs { get; set; } = new List<Utilisateur>();

    public virtual ICollection<Utilisateur> Idutilisateurs { get; set; } = new List<Utilisateur>();
}
