using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejercicio1._1._1.Models
{
    public class Producto
    {
        [Key]
        public int productoID { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }
}