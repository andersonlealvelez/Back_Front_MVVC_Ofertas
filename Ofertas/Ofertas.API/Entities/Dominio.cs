using System;
using System.Collections.Generic;

namespace Ofertas.API.Entities;

public partial class Dominio
{
    public string DerechoTipo { get; set; } = null!;

    public long IdOferta { get; set; }

    public virtual Ofertum IdOfertaNavigation { get; set; } = null!;
}
