using Ofertas.API.Entities;

namespace Ofertas.API.DTO
{
    public class PeritoDTO
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
}
