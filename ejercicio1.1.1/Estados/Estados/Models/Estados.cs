using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estados.Models
{
    public class Estados
    {
        public int estadoID { get; set; }
        public string estado { get; set; }

        public virtual ICollection<Municipios> municipios { get; set; }
    }
}