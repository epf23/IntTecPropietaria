using FluentValidation.Attributes;
using SistemadeCompras.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{

    [Validator(typeof(ValidatorDepartamento))]


    public class Departamento
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Estado { get; set; }



    }
}