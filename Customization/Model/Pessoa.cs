using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Model
{
    public class Pessoa
    {
        public Pessoa(string codigo, string razaoSocial,string apelido, string cpfCnpj,
                        string conexao, string usuario, string senha, string cadastro,
                        string atualizado, string telefone1, string telefone2, string email)
        {
            this.codigo = codigo;
            this.razaoSocial = razaoSocial;
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

        public string razaoSocial { get; set; }

        public string apelido { get; set; }

        public string cpfCnpj { get; set; }

        public string conexao { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public string cadastro { get; set; }

        public string atualizado { get; set; }

        public string telefone1 { get; set; }

        public string telefone2 { get; set; }

        public string email { get; set; }

        public override string ToString()
        {
            return this.razaoSocial;
        }
    }
}
