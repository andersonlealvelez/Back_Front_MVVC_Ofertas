using System;
using System.Collections.Generic;

namespace Ofertas.API.Entities;

public partial class Perito
{
    public long IdOferta { get; set; }

    public string NumeroIdentificacion { get; set; } = null!;

    public string TipoIdentificacion { get; set; } = null!;

    public string RevisionPersonaResponsable { get; set; } = null!;

    public string RevisionAreaResponsable { get; set; } = null!;

    public string ProyectoEmailPersonal { get; set; } = null!;

    public string ProyectoPersonaResponsable { get; set; } = null!;

    public string ProyectoAreaResponsable { get; set; } = null!;

    public virtual Ofertum IdOfertaNavigation { get; set; } = null!;

    public virtual Persona Persona { get; set; } = null!;
}
