using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Pessoas
    {
        public string codigo { get; set; }

        public string razaoSocial { get; set; }

        public string apelido { get; set; }

        public string cpfCnpj { get; set; }

        public override string ToString()
        {
            return this.razaoSocial;
        }
    }
}
