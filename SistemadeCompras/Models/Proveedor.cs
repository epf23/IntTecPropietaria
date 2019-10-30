using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{
    public class Proveedor
    {

        public int Id { get; set; }

        public string Cedula_RNC { get; set; }

        public string Nombre_Comercial { get; set; }

        public string Estado { get; set;}

    }
}