using SistemadeCompras.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemadeCompras.Models
{

    [FluentValidation.Attributes.Validator(typeof(ValidatorunidadMedida))]

    public class UnidadMedida
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public ICollection<Articulo> articulos { get; set; }

        public IEnumerable<SelectListItem> Estados { get; set; }

    }
}