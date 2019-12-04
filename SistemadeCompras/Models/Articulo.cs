using SistemadeCompras.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{


    [FluentValidation.Attributes.Validator(typeof(ValidatorArticulo))]



    public class Articulo
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Unidad de Medida")]
        public int Id_Unidad_Medida { get; set; }

        public UnidadMedida unidadMedida { get; set; }

        [Display(Name = "Existencia")]
        public int Existencia { get; set; }
        
    }

    //public class ArticuloDBContext : DbContext
    //{
    //    public DbSet<Articulo> Articulos { get; set; }
    //}


}