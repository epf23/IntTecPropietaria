using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Models
{
    public class Articulo
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public int Id_Unidad_Medida { get; set; }

        public UnidadMedida unidadMedida { get; set; }

        public int Existencia { get; set; }


    }
}