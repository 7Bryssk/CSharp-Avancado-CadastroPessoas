using Dominio;
using Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        public int Adicionar(Pessoa objeto)
        {
            CadastroPessoasDbContext contexto = new CadastroPessoasDbContext();
            contexto.Pessoas.Add(objeto);
            return contexto.SaveChanges();
        }

        public List<Pessoa> SelecionarTodos()
        {
            CadastroPessoasDbContext contexto = new CadastroPessoasDbContext();
            List<Pessoa> pessoas = contexto.Pessoas.OrderBy(o => o.nome).ToList();
            contexto.Dispose();
            return pessoas;
        }
    }
}
