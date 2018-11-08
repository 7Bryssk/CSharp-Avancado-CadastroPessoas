using Dominio;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using Persistencia.NHibernate.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioNHibernate
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        private ISessionFactory _sessionFactory;

        public PessoaRepositorio()
        {
            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Pessoa).Assembly);
            HbmMapping mapping = CreateMappings();
            config.AddDeserializedMapping(mapping, null);
            _sessionFactory = config.BuildSessionFactory();
        }

        private HbmMapping CreateMappings()
        {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping(typeof(PessoaMap));

            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }

        public int Adicionar(Pessoa objeto)
        {
            using (ISession sessao = _sessionFactory.OpenSession())
            {
                using (var transacao = sessao.BeginTransaction())
                {
                    sessao.Save(objeto);
                    transacao.Commit();
                    return 0;
                }
            }
        }

        public List<Pessoa> SelecionarTodos()
        {
            using (ISession sessao = _sessionFactory.OpenSession())
            {
                IQuery consulta = sessao.CreateQuery("FROM Pessoa");

                return consulta.List<Pessoa>().ToList();
            }
        }
    }
}
