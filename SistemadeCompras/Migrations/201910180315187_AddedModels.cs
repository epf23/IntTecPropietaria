namespace SistemadeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrdenCompras",
                c => new
                    {
                        Num_Orden = c.Int(nullable: false, identity: true),
                        FechaOrden = c.DateTime(nullable: false),
                        Estado = c.String(),
                        IdArticulo = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        CostoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Num_Orden);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula_RNC = c.String(),
                        Nombre_Comercial = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedors");
            DropTable("dbo.OrdenCompras");
            DropTable("dbo.Departamentoes");
        }
    }
}
