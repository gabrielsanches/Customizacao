using Customization.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface CustomizacaoDAO
    {
        DataTable Buscar(int codigo);
        void Salvar(Customizacao customizacao);
        bool Remover(Customizacao customizacao);
    }
}
