namespace SistemadeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Marca = c.String(),
                        Id_Unidad_Medida = c.Int(nullable: false),
                        Existencia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UnidadMedidas", t => t.Id_Unidad_Medida, cascadeDelete: true)
                .Index(t => t.Id_Unidad_Medida);
            
            CreateTable(
                "dbo.UnidadMedidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articuloes", "Id_Unidad_Medida", "dbo.UnidadMedidas");
            DropIndex("dbo.Articuloes", new[] { "Id_Unidad_Medida" });
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.Articuloes");
        }
    }
}
