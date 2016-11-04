using Customization.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface TipoDAO
    {
        void Salvar(Tipo tipo);
        DataTable ListarTodos();
        DataTable BuscarCodigo(int codigo);
    }
}
