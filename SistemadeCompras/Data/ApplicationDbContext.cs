using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Data
{
    public class ApplicationDbContext : DbContext
    {
        //String de conexión BD

        public ApplicationDbContext():base("DefaultConnection")
            {

            }

        //Creación relaciones

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Articulo>()
                .HasRequired<UnidadMedida>(b => b.unidadMedida)
                .WithMany(a => a.articulos)
                .HasForeignKey<int>(b => b.Id_Unidad_Medida);

        }

        DbSet<Articulo> articulos { get; set; }

        DbSet<Proveedor> proveedores { get; set; }

        DbSet<OrdenCompra> ordenCompras { get; set; }

        DbSet<Departamento> departamentos { get; set; }

        //DbSet<UnidadMedida> unidadMedidas { get; set; }

        public System.Data.Entity.DbSet<SistemadeCompras.Models.UnidadMedida> UnidadMedidas { get; set; }
    }
}