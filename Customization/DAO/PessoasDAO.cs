﻿using Customization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.DAO
{
    public interface PessoasDAO
    {
        void Salvar(Pessoa pessoa);
        List<Pessoa> BuscarCodigo(string codigo);
        List<Pessoa> BuscarRazao(string nome);
    }
}
