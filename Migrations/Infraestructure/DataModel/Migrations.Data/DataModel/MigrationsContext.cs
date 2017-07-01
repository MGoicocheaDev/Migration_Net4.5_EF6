using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using Migrations.Entities.DataModel;

namespace Migrations.Data.DataModel
{
   

    public class MigrationsContext : DbContext
    {
        
        public MigrationsContext()
            : base("name=MigrationsContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Persona

            modelBuilder.Entity<Persona>()
                        .Property(x => x.Nombre)
                        .HasMaxLength(300)
                        .IsRequired();

            modelBuilder.Entity<Persona>()
                        .Property(x => x.Apellido)
                        .HasMaxLength(300)
                        .IsRequired();

            modelBuilder.Entity<Persona>()
                .Property(x => x.NumeroDocumento)
                .HasMaxLength(20)
                .IsOptional();

            modelBuilder.Entity<Persona>()
                .Property(x => x.FechaActualizacion)                
                .IsOptional();

            #endregion

            #region Ubigeo

            modelBuilder.Entity<Ubigeo>()
                .HasKey(x => x.CodigoUbigeo)
                .Property(x => x.CodigoUbigeo)
                .HasMaxLength(6)
                .HasColumnType("char")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Departamento)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Provincia)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Distrito)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Pais

            modelBuilder.Entity<Pais>()
                .Property(x => x.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Domicilio

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.TipoDireccion)
                .IsRequired();

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Direccion)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Seccion)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Urbanizacion)
                .IsOptional()
                .HasMaxLength(150);

            #endregion

            #region Formacion

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Titulo)
                .HasMaxLength(250)
                .IsRequired();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Institucion)
                .HasMaxLength(300)
                .IsRequired();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.MesFin)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.AnioFin)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.MesInicio)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.AnioInicio)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Promedio)
                .IsOptional();
            #endregion
        }

        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Formacion> Formacion { get; set; }
        public virtual DbSet<TipoFormacion> TipoFormacion { get; set; }
        public virtual DbSet<EstadoFormacion> EstadoFormacion { get; set; }
        public virtual DbSet<AreaFormacion> AreaEstudio { get; set; }
    }

}