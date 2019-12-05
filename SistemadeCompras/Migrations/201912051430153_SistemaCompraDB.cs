namespace SistemadeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaCompraDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articuloes", "Id_Unidad_Medida", c => c.Int(nullable: false));
            DropColumn("dbo.Articuloes", "Unidad_Medida");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articuloes", "Unidad_Medida", c => c.String());
            DropColumn("dbo.Articuloes", "Id_Unidad_Medida");
        }
    }
}
