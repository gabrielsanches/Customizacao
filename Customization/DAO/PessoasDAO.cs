using Customization.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface PessoasDAO
    {
        void Salvar(Pessoa pessoa);
        DataTable BuscarCodigo(string codigo);
        DataTable BuscarRazao(string nome);
    }
}
