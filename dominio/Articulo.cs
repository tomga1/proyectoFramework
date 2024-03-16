using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        public int id { get; set; }

        public string codigo { get; set; }

        public string descripcion { get; set; }

        public string proveedor { get; set; }

        public int stock { get; set; }
        public string UrlImagen { get; set; }


    }
}
