using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Pessoas
    {
        public Pessoas(string codigo, string razaoSocial,string apelido, string cpfCnpj)
        {
            this.codigo = codigo;
            this.razaoSocial = razaoSocial;
            this.apelido = apelido;
            this.cpfCnpj = cpfCnpj;
        }

        public string codigo { get; set; }

        public string razaoSocial { get; set; }

        public string apelido { get; set; }

        public string cpfCnpj { get; set; }

        public string telefone1 { get; set; }

        public override string ToString()
        {
            return this.razaoSocial;
        }
    }
}
