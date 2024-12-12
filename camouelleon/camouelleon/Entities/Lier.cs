using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Lier
{
    public int Idetat { get; set; }

    public int Idcommande { get; set; }

    public DateTime Dateheure { get; set; }

    public virtual Commande IdcommandeNavigation { get; set; } = null!;

    public virtual Etat IdetatNavigation { get; set; } = null!;
}
