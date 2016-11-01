using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Customizacao
    {
        public Customizacao(int id, Pessoa programador, Pessoa cliente, Tipo tipo, string query, string inicio, string fim, string entrega)
        {
            this.id = id;
            this.programador = programador;
            this.cliente = cliente;
            this.tipo = tipo;
            this.query = query;
            this.inicio = inicio;
            this.fim = fim;
            this.entrega = entrega;
        }

        public Customizacao()
        {
        }

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
