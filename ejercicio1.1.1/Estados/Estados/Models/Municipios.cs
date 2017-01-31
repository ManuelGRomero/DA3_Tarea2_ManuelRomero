using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estados.Models
{
    public class Municipios
    {
        public int municipioID { get; set; }
        public string municipio { get; set; }

        public int estadoID { get; set; }
        virtual public Estados estado { get; set; }
    }
}