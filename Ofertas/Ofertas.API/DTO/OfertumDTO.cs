using Ofertas.API.Entities;

namespace Ofertas.API.DTO
{
    public class OfertumDTO
    {
        public long IdOferta { get; set; }

        public DateOnly FechaCapturaOferta { get; set; }

        public string TipoOferta { get; set; } = null!;

        public string? SiValorIncluyeAnexidades { get; set; }

        public int? TiempoOfertaMercado { get; set; }

        public string? OfertaOrigen { get; set; }

        public int ValorOfertaInicial { get; set; }

        public int PorcentajeNegociacion { get; set; }

        public int ValorOfertaFinal { get; set; }

        public int? ValorTerreno { get; set; }

        public int? ValorConstruccionM2 { get; set; }

        public int? ValorAreaPrivada { get; set; }

        public int ValorCultivo { get; set; }

        public int? AvaluoCatastral { get; set; }

        public int ValorAdministracion { get; set; }

        public int ValorArriendoInicial { get; set; }

        public int ValorArriendoFinal { get; set; }

        public int? ValorTerrazaBalconPatio { get; set; }

        public int? ValorGarajes { get; set; }

        public int? ValorDepositos { get; set; }

        public int ValorAnexidades { get; set; }

        public string NombreOferente { get; set; } = null!;

        public int NumeroContacto { get; set; }

        public string? Url { get; set; }

        public string? EnlaceInternoFotoPredio { get; set; }

        public string? EnlaceDocumentos { get; set; }

        public string Observaciones { get; set; } = null!;

        public short EstadoOferta { get; set; }

        public virtual Dominio? Dominio { get; set; }

        public virtual Inmueble? Inmueble { get; set; }

        public virtual ICollection<Perito> Peritos { get; set; } = new List<Perito>();

        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();

        public virtual ICollection<Tenedor> Tenedors { get; set; } = new List<Tenedor>();
    }
}
