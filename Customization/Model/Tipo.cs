using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Tipo
    {
        public Tipo(){}

        public Tipo(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public int codigo { get; set; }

        public string descricao { get; set; }
    }
}
