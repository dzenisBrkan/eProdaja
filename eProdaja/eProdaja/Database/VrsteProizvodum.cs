﻿using System;
using System.Collections.Generic;

namespace eProdaja.Database;

public partial class VrsteProizvodum
{
    public int VrstaId { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Proizvodi> Proizvodis { get; set; } = new List<Proizvodi>();
}
