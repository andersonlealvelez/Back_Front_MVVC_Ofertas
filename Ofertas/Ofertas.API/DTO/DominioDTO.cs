using Ofertas.API.Entities;

namespace Ofertas.API.DTO
{
    public class DominioDTO
    {
        public string DerechoTipo { get; set; } = null!;

        public long IdOferta { get; set; }

        public virtual Ofertum IdOfertaNavigation { get; set; } = null!;
    }
}
