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
            DropTable("dbo.Usuarios");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.OrdenCompras", "articuloC_Id", "dbo.Articuloes");
            DropIndex("dbo.OrdenCompras", new[] { "articuloC_Id" });
            DropColumn("dbo.OrdenCompras", "articuloC_Id");
        }
    }
}
