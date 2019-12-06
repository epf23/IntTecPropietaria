namespace SistemadeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaCompraDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrdenCompras", "articuloC_Id", c => c.Int());
            CreateIndex("dbo.OrdenCompras", "articuloC_Id");
            AddForeignKey("dbo.OrdenCompras", "articuloC_Id", "dbo.Articuloes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdenCompras", "articuloC_Id", "dbo.Articuloes");
            DropIndex("dbo.OrdenCompras", new[] { "articuloC_Id" });
            DropColumn("dbo.OrdenCompras", "articuloC_Id");
        }
    }
}
