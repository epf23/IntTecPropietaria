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
        public int Num_Orden { get; set; }

        public DateTime FechaOrden { get; set; }

        public string Estado { get; set; }
        
        public int IdArticulo { get; set; }

        public int Cantidad { get; set; }

        public decimal CostoUnitario { get; set; }


    }
}