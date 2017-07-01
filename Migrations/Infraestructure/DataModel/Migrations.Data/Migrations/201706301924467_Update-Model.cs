namespace Migrations.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExperienciaLaboral",
                c => new
                    {
                        ExperienciaLaboralId = c.Long(nullable: false, identity: true),
                        PersonaId = c.Long(nullable: false),
                        Empresa = c.String(),
                        ActividadEmpresaId = c.Int(nullable: false),
                        Puesto = c.String(),
                        NivelExperiencia = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Presente = c.Boolean(nullable: false),
                        AreaLaboralId = c.Int(nullable: false),
                        DescripcionResponsabilidad = c.String(),
                        PersonasACargo = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExperienciaLaboralId)
                .ForeignKey("dbo.ActividadEmpresa", t => t.ActividadEmpresaId, cascadeDelete: true)
                .ForeignKey("dbo.AreaLaboral", t => t.AreaLaboralId, cascadeDelete: true)
                .ForeignKey("dbo.Persona", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.ActividadEmpresaId)
                .Index(t => t.AreaLaboralId);
            
            CreateTable(
                "dbo.ActividadEmpresa",
                c => new
                    {
                        ActividadEmpresaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ActividadEmpresaId);
            
            CreateTable(
                "dbo.AreaLaboral",
                c => new
                    {
                        AreaLaboralId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AreaLaboralId);
            
            AddColumn("dbo.Formacion", "PaisId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExperienciaLaboral", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.ExperienciaLaboral", "AreaLaboralId", "dbo.AreaLaboral");
            DropForeignKey("dbo.ExperienciaLaboral", "ActividadEmpresaId", "dbo.ActividadEmpresa");
            DropIndex("dbo.ExperienciaLaboral", new[] { "AreaLaboralId" });
            DropIndex("dbo.ExperienciaLaboral", new[] { "ActividadEmpresaId" });
            DropIndex("dbo.ExperienciaLaboral", new[] { "PersonaId" });
            DropColumn("dbo.Formacion", "PaisId");
            DropTable("dbo.AreaLaboral");
            DropTable("dbo.ActividadEmpresa");
            DropTable("dbo.ExperienciaLaboral");
        }
    }
}
