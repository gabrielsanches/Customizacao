using Customization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface PessoasDAO
    {
        void Salvar(Pessoas pessoa);
        List<Pessoas> BuscarCodigo(string codigo);
        List<Pessoas> BuscarRazao(string nome);
    }
}
