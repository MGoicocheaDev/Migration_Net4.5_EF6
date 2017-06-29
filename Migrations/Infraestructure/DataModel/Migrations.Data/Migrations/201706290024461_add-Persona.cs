namespace Migrations.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPersona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persona", "DomicilioId", c => c.Long(nullable: false));
            CreateIndex("dbo.Persona", "DomicilioId");
            AddForeignKey("dbo.Persona", "DomicilioId", "dbo.Domicilio", "DomicilioId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persona", "DomicilioId", "dbo.Domicilio");
            DropIndex("dbo.Persona", new[] { "DomicilioId" });
            DropColumn("dbo.Persona", "DomicilioId");
        }
    }
}
