using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Utilisateur
{
    public int Idutilisateur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string? Telephone { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Idrole { get; set; }

    public virtual Role IdroleNavigation { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Avi> Idavis { get; set; } = new List<Avi>();

    public virtual ICollection<Role> Idroles { get; set; } = new List<Role>();
}
