using FluentValidation.Attributes;
using SistemadeCompras.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{

    [Validator(typeof(ValidatorProveedor))]

    public class Proveedor
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Cedula / RNC")]
        public string Cedula_RNC { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre_Comercial { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set;}

    }
}