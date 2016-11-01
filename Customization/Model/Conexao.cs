using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Conexao
    {

        public Conexao()
        {
        }
        
        public Conexao(string cliente, string servidor, string porta, string banco, string usuario, string senha)
        {
            this.cliente = cliente;
            this.servidor = servidor;
            this.porta = porta;
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        public string cliente { get; set; }

        public string servidor { get; set; }

        public string porta { get; set; }

        public string banco { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }
    }
}
