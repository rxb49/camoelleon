using System;
using System.Collections.Generic;

namespace camouelleon.Entities;

public partial class Produit
{
    public int Idproduit { get; set; }

    public int Idunite { get; set; }

    public string Lblunite { get; set; } = null!;

    public string Lblproduit { get; set; } = null!;

    public short? Menudujour { get; set; }

    public virtual ICollection<Attribuer> Attribuers { get; set; } = new List<Attribuer>();

    public virtual ICollection<Ranger> Rangers { get; set; } = new List<Ranger>();

    public virtual ICollection<Reaprovisionner> Reaprovisionners { get; set; } = new List<Reaprovisionner>();

    public virtual Unite Unite { get; set; } = null!;

    public virtual ICollection<Allergie> Idallergies { get; set; } = new List<Allergie>();

    public virtual ICollection<Dechet> Iddechets { get; set; } = new List<Dechet>();
}
