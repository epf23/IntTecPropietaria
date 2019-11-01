using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{
    public class OrdenCompra
    {
        [Key]
        [Display(Name = "Numero de Orden")]
        public int Num_Orden { get; set; }

        [Display(Name = "Fecha de Orden")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime FechaOrden { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Codigo de Artículo")]
        public int IdArticulo { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio Unitario")]
        public decimal CostoUnitario { get; set; }


    }
}