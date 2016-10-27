using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Customizacao
    {
        public int id { get; set; }

        public string fk_programador { get; set; }

        public string fk_cliente { get; set; }

        public int fk_tipo{get;set;}

        public string query { get; set; }

        public DateTime inicio { get; set; }

        public DateTime fim { get; set; }

        public DateTime entrega { get; set; }
    }
}
