using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string codigo, string nome,string apelido, string cpfCnpj,
                        string conexao, string usuario, string senha, DateTime cadastro,
                        DateTime atualizado, string telefone1, string telefone2, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.apelido = apelido;
            this.cpfCnpj = cpfCnpj;
            this.conexao = conexao;
            this.usuario = usuario;
            this.senha = senha;
            this.cadastro = cadastro;
            this.atualizado = atualizado;
            this.telefone1 = telefone1;
            this.telefone2 = telefone2;
            this.email = email;
        }

        public string codigo { get; set; }

        public string nome { get; set; }

        public string apelido { get; set; }

        public string cpfCnpj { get; set; }

        public string conexao { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public DateTime cadastro { get; set; }

        public DateTime atualizado { get; set; }

        public string telefone1 { get; set; }

        public string telefone2 { get; set; }

        public string email { get; set; }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
