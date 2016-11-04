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

        public Tipo(int idtipo, string descricao)
        {
            this.idtipo = idtipo;
            this.descricao = descricao;
        }

        public int idtipo { get; set; }

        public string descricao { get; set; }

        public override string ToString()
        {
            return this.descricao;
        }
    }
    
}
