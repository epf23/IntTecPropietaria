using FluentValidation.Attributes;
using SistemadeCompras.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemadeCompras.Models
{

    [Validator(typeof(ValidatorOrdenCompra))]
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

        public IEnumerable<SelectListItem> Estados { get; set; }

    }
}