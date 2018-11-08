using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual int idade { get; set; }
        public virtual string endereco { get; set; }

    }
}
