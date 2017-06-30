namespace Migrations.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaEstudio",
                c => new
                    {
                        AreaEstudioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AreaEstudioId);
            
            CreateTable(
                "dbo.EstadoFormacion",
                c => new
                    {
                        EstadoFormacionId = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoFormacionId);
            
            CreateTable(
                "dbo.Formacion",
                c => new
                    {
                        FormacionId = c.Long(nullable: false, identity: true),
                        PersonaId = c.Long(nullable: false),
                        TipoFormacionId = c.Byte(nullable: false),
                        EstadoFormacionId = c.Byte(nullable: false),
                        Titulo = c.String(),
                        AreaEstudioId = c.Int(nullable: false),
                        Institucion = c.String(),
                        MesInicio = c.Byte(nullable: false),
                        AnioInicio = c.Byte(nullable: false),
                        MesFin = c.Byte(nullable: false),
                        AnioFin = c.Byte(nullable: false),
                        Actual = c.Boolean(nullable: false),
                        Promedio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FormacionId)
                .ForeignKey("dbo.AreaEstudio", t => t.AreaEstudioId, cascadeDelete: true)
                .ForeignKey("dbo.EstadoFormacion", t => t.EstadoFormacionId, cascadeDelete: true)
                .ForeignKey("dbo.Persona", t => t.PersonaId, cascadeDelete: true)
                .ForeignKey("dbo.TipoFormacion", t => t.TipoFormacionId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.TipoFormacionId)
                .Index(t => t.EstadoFormacionId)
                .Index(t => t.AreaEstudioId);
            
            CreateTable(
                "dbo.TipoFormacion",
                c => new
                    {
                        TipoFormacionId = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoFormacionId);
            
            AddColumn("dbo.Domicilio", "FechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Domicilio", "FechaActualizacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formacion", "TipoFormacionId", "dbo.TipoFormacion");
            DropForeignKey("dbo.Formacion", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.Formacion", "EstadoFormacionId", "dbo.EstadoFormacion");
            DropForeignKey("dbo.Formacion", "AreaEstudioId", "dbo.AreaEstudio");
            DropIndex("dbo.Formacion", new[] { "AreaEstudioId" });
            DropIndex("dbo.Formacion", new[] { "EstadoFormacionId" });
            DropIndex("dbo.Formacion", new[] { "TipoFormacionId" });
            DropIndex("dbo.Formacion", new[] { "PersonaId" });
            DropColumn("dbo.Domicilio", "FechaActualizacion");
            DropColumn("dbo.Domicilio", "FechaCreacion");
            DropTable("dbo.TipoFormacion");
            DropTable("dbo.Formacion");
            DropTable("dbo.EstadoFormacion");
            DropTable("dbo.AreaEstudio");
        }
    }
}
