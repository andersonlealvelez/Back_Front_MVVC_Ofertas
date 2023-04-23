using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ofertas.API.Entities;

public partial class OfertasContext : DbContext
{
    public OfertasContext()
    {
    }

    public OfertasContext(DbContextOptions<OfertasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dominio> Dominios { get; set; }

    public virtual DbSet<Inmueble> Inmuebles { get; set; }

    public virtual DbSet<Ofertum> Oferta { get; set; }

    public virtual DbSet<Perito> Peritos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Tenedor> Tenedors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dominio>(entity =>
        {
            entity.HasKey(e => e.IdOferta).HasName("dominio_pkey");

            entity.ToTable("dominio");

            entity.Property(e => e.IdOferta)
                .ValueGeneratedNever()
                .HasColumnName("id_oferta");
            entity.Property(e => e.DerechoTipo)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("derecho_tipo");

            entity.HasOne(d => d.IdOfertaNavigation).WithOne(p => p.Dominio)
                .HasForeignKey<Dominio>(d => d.IdOferta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_idoferta_dominio");
        });

        modelBuilder.Entity<Inmueble>(entity =>
        {
            entity.HasKey(e => e.IdOferta).HasName("inmueble_pkey");

            entity.ToTable("inmueble");

            entity.Property(e => e.IdOferta)
                .ValueGeneratedNever()
                .HasColumnName("id_oferta");
            entity.Property(e => e.AlturaEdificio).HasColumnName("altura_edificio");
            entity.Property(e => e.AnoConstruccion).HasColumnName("ano_construccion");
            entity.Property(e => e.AreaConstruccion).HasColumnName("area_construccion");
            entity.Property(e => e.AreaCultivo).HasColumnName("area_cultivo");
            entity.Property(e => e.AreaPrivada).HasColumnName("area_privada");
            entity.Property(e => e.AreaTerreno).HasColumnName("area_terreno");
            entity.Property(e => e.Barrio)
                .HasMaxLength(100)
                .HasColumnName("barrio");
            entity.Property(e => e.CodigoHomologado)
                .HasMaxLength(100)
                .HasColumnName("codigo_homologado");
            entity.Property(e => e.Coeficiente).HasColumnName("coeficiente");
            entity.Property(e => e.CondicionJuridica)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("condicion_juridica");
            entity.Property(e => e.Conservacion)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("conservacion");
            entity.Property(e => e.ConstruccionesAnexas)
                .HasMaxLength(256)
                .HasColumnName("construcciones_anexas");
            entity.Property(e => e.Departamento)
                .HasMaxLength(2)
                .HasColumnName("departamento");
            entity.Property(e => e.DestinacionEconomica)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("destinacion_economica");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.EdadCultivo).HasColumnName("edad_cultivo");
            entity.Property(e => e.Estrato).HasColumnName("estrato");
            entity.Property(e => e.Garajes).HasColumnName("garajes");
            entity.Property(e => e.Latitud)
                .HasPrecision(12, 7)
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasPrecision(12, 7)
                .HasColumnName("longitud");
            entity.Property(e => e.MatriculaInmobiliaria)
                .HasMaxLength(100)
                .HasColumnName("matricula_inmobiliaria");
            entity.Property(e => e.Municipio)
                .HasMaxLength(5)
                .HasColumnName("municipio");
            entity.Property(e => e.NumeroBanos).HasColumnName("numero_banos");
            entity.Property(e => e.NumeroDepositos).HasColumnName("numero_depositos");
            entity.Property(e => e.NumeroHabitaciones).HasColumnName("numero_habitaciones");
            entity.Property(e => e.NumeroPiso).HasColumnName("numero_piso");
            entity.Property(e => e.NumeroPredialAntiguo)
                .HasMaxLength(20)
                .HasColumnName("numero_predial_antiguo");
            entity.Property(e => e.NumeroPredialNuevo)
                .HasMaxLength(30)
                .HasColumnName("numero_predial_nuevo");
            entity.Property(e => e.ProyectoDescripcion)
                .HasMaxLength(100)
                .HasColumnName("proyecto_descripcion");
            entity.Property(e => e.ProyectoInmobiliario)
                .HasMaxLength(2)
                .HasColumnName("proyecto_inmobiliario");
            entity.Property(e => e.ServiciosPublicos)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("servicios_publicos");
            entity.Property(e => e.TipoCultivo)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("tipo_cultivo");
            entity.Property(e => e.TipoInmueble)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("tipo_inmueble");
            entity.Property(e => e.TipoInmuebleRural)
                .HasMaxLength(100)
                .HasColumnName("tipo_inmueble_rural");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("tipo_predio");
            entity.Property(e => e.TipologiaTipo)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("tipologia_tipo");
            entity.Property(e => e.Vereda)
                .HasMaxLength(100)
                .HasColumnName("vereda");

            entity.HasOne(d => d.IdOfertaNavigation).WithOne(p => p.Inmueble)
                .HasForeignKey<Inmueble>(d => d.IdOferta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_idoferta_inmueble");
        });

        modelBuilder.Entity<Ofertum>(entity =>
        {
            entity.HasKey(e => e.IdOferta).HasName("oferta_pkey");

            entity.ToTable("oferta");

            entity.Property(e => e.IdOferta)
                .HasDefaultValueSql("nextval('id_seq'::regclass)")
                .HasColumnName("id_oferta");
            entity.Property(e => e.AvaluoCatastral).HasColumnName("avaluo_catastral");
            entity.Property(e => e.EnlaceDocumentos)
                .HasMaxLength(100)
                .HasColumnName("enlace_documentos");
            entity.Property(e => e.EnlaceInternoFotoPredio)
                .HasMaxLength(100)
                .HasColumnName("enlace_interno_foto_predio");
            entity.Property(e => e.EstadoOferta).HasColumnName("estado_oferta");
            entity.Property(e => e.FechaCapturaOferta).HasColumnName("fecha_captura_oferta");
            entity.Property(e => e.NombreOferente)
                .HasMaxLength(512)
                .HasColumnName("nombre_oferente");
            entity.Property(e => e.NumeroContacto).HasColumnName("numero_contacto");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .HasColumnName("observaciones");
            entity.Property(e => e.OfertaOrigen)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("oferta_origen");
            entity.Property(e => e.PorcentajeNegociacion).HasColumnName("porcentaje_negociacion");
            entity.Property(e => e.SiValorIncluyeAnexidades)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("si_valor_incluye_anexidades");
            entity.Property(e => e.TiempoOfertaMercado).HasColumnName("tiempo_oferta_mercado");
            entity.Property(e => e.TipoOferta)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tipo_oferta");
            entity.Property(e => e.Url)
                .HasMaxLength(512)
                .HasColumnName("url");
            entity.Property(e => e.ValorAdministracion).HasColumnName("valor_administracion");
            entity.Property(e => e.ValorAnexidades).HasColumnName("valor_anexidades");
            entity.Property(e => e.ValorAreaPrivada).HasColumnName("valor_area_privada");
            entity.Property(e => e.ValorArriendoFinal).HasColumnName("valor_arriendo_final");
            entity.Property(e => e.ValorArriendoInicial).HasColumnName("valor_arriendo_inicial");
            entity.Property(e => e.ValorConstruccionM2).HasColumnName("valor_construccion_m2");
            entity.Property(e => e.ValorCultivo).HasColumnName("valor_cultivo");
            entity.Property(e => e.ValorDepositos).HasColumnName("valor_depositos");
            entity.Property(e => e.ValorGarajes).HasColumnName("valor_garajes");
            entity.Property(e => e.ValorOfertaFinal).HasColumnName("valor_oferta_final");
            entity.Property(e => e.ValorOfertaInicial).HasColumnName("valor_oferta_inicial");
            entity.Property(e => e.ValorTerrazaBalconPatio).HasColumnName("valor_terraza_balcon_patio");
            entity.Property(e => e.ValorTerreno).HasColumnName("valor_terreno");
        });

        modelBuilder.Entity<Perito>(entity =>
        {
            entity.HasKey(e => new { e.NumeroIdentificacion, e.TipoIdentificacion, e.IdOferta }).HasName("perito_pkey");

            entity.ToTable("perito");

            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(30)
                .HasColumnName("numero_identificacion");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(10)
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.IdOferta).HasColumnName("id_oferta");
            entity.Property(e => e.ProyectoAreaResponsable)
                .HasMaxLength(100)
                .HasColumnName("proyecto_area_responsable");
            entity.Property(e => e.ProyectoEmailPersonal)
                .HasMaxLength(100)
                .HasColumnName("proyecto_email_personal");
            entity.Property(e => e.ProyectoPersonaResponsable)
                .HasMaxLength(100)
                .HasColumnName("proyecto_persona_responsable");
            entity.Property(e => e.RevisionAreaResponsable)
                .HasMaxLength(100)
                .HasColumnName("revision_area_responsable");
            entity.Property(e => e.RevisionPersonaResponsable)
                .HasMaxLength(100)
                .HasColumnName("revision_persona_responsable");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.Peritos)
                .HasForeignKey(d => d.IdOferta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_idoferta_perito");

            entity.HasOne(d => d.Persona).WithOne(p => p.Perito)
                .HasForeignKey<Perito>(d => new { d.NumeroIdentificacion, d.TipoIdentificacion, d.IdOferta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_esp_perito");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => new { e.NumeroIdentificacion, e.TipoIdentificacion, e.IdOferta }).HasName("persona_pkey");

            entity.ToTable("persona");

            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(30)
                .HasColumnName("numero_identificacion");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(10)
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.IdOferta).HasColumnName("id_oferta");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdOferta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_idoferta_persona");
        });

        modelBuilder.Entity<Tenedor>(entity =>
        {
            entity.HasKey(e => new { e.NumeroIdentificacion, e.TipoIdentificacion, e.IdOferta }).HasName("tenedor_pkey");

            entity.ToTable("tenedor");

            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(30)
                .HasColumnName("numero_identificacion");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(10)
                .HasColumnName("tipo_identificacion");
            entity.Property(e => e.IdOferta).HasColumnName("id_oferta");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.Tenedors)
                .HasForeignKey(d => d.IdOferta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_idoferta_tenedor");

            entity.HasOne(d => d.Persona).WithOne(p => p.Tenedor)
                .HasForeignKey<Tenedor>(d => new { d.NumeroIdentificacion, d.TipoIdentificacion, d.IdOferta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("res_esp_tenedor");
        });
        modelBuilder.HasSequence("id_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
