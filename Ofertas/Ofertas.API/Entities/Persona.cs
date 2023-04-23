using System;
using System.Collections.Generic;

namespace Ofertas.API.Entities;

public partial class Persona
{
    public string NumeroIdentificacion { get; set; } = null!;

    public string TipoIdentificacion { get; set; } = null!;

    public long IdOferta { get; set; }

    public virtual Ofertum IdOfertaNavigation { get; set; } = null!;

    public virtual Perito? Perito { get; set; }

    public virtual Tenedor? Tenedor { get; set; }
}
