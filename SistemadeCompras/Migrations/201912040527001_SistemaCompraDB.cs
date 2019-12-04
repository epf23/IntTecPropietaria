namespace SistemadeCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaCompraDB : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Usuarios");
            AddColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Usuarios", "Email", c => c.String());
            AddPrimaryKey("dbo.Usuarios", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Usuarios", "Id");
            AddPrimaryKey("dbo.Usuarios", "Email");
        }
    }
}
