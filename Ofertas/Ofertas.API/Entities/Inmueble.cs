using System;
using System.Collections.Generic;

namespace Ofertas.API.Entities;

public partial class Inmueble
{
    public long IdOferta { get; set; }

    public string? NumeroPredialNuevo { get; set; }

    public string? NumeroPredialAntiguo { get; set; }

    public string? CodigoHomologado { get; set; }

    public string Departamento { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string Vereda { get; set; } = null!;

    public string Barrio { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string TipoInmueble { get; set; } = null!;

    public string TipoPredio { get; set; } = null!;

    public string? ProyectoInmobiliario { get; set; }

    public string? ProyectoDescripcion { get; set; }

    public int AreaTerreno { get; set; }

    public int? AnoConstruccion { get; set; }

    public int AreaConstruccion { get; set; }

    public string Conservacion { get; set; } = null!;

    public int AreaPrivada { get; set; }

    public string DestinacionEconomica { get; set; } = null!;

    public int? AlturaEdificio { get; set; }

    public int? NumeroPiso { get; set; }

    public string TipoInmuebleRural { get; set; } = null!;

    public string? TipologiaTipo { get; set; }

    public int? AreaCultivo { get; set; }

    public int? EdadCultivo { get; set; }

    public string? TipoCultivo { get; set; }

    public int? Coeficiente { get; set; }

    public string ServiciosPublicos { get; set; } = null!;

    public int? Estrato { get; set; }

    public int Garajes { get; set; }

    public int NumeroBanos { get; set; }

    public int NumeroHabitaciones { get; set; }

    public int NumeroDepositos { get; set; }

    public string ConstruccionesAnexas { get; set; } = null!;

    public string? MatriculaInmobiliaria { get; set; }

    public string CondicionJuridica { get; set; } = null!;

    public virtual Ofertum IdOfertaNavigation { get; set; } = null!;
}
