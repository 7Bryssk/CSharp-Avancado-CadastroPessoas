﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioNHibernate
{
    public interface IRepositorio<Ttipo>
    {
        List<Ttipo> SelecionarTodos();
        int Adicionar(Ttipo objeto);
    }
}