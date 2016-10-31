using Customization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface TipoDAO
    {
        void Salvar(Tipo tipo);
        List<Tipo> ListarTodos();
    }
}
