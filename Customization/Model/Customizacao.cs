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

        public Pessoa programador { get; set; }

        public Pessoa cliente { get; set; }

        public Tipo tipo{get;set;}

        public string query { get; set; }

        public string inicio { get; set; }

        public string fim { get; set; }

        public string entrega { get; set; }
    }
}
