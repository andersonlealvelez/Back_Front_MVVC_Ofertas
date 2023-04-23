using Ofertas.API.Entities;

namespace Ofertas.API.DTO
{
    public class TenedorDTO
    {
        public string NumeroIdentificacion { get; set; } = null!;

        public string TipoIdentificacion { get; set; } = null!;

        public long IdOferta { get; set; }

        public virtual Ofertum IdOfertaNavigation { get; set; } = null!;

        public virtual Persona Persona { get; set; } = null!;
    }
}
