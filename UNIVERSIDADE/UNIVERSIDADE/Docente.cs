using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
    public class Docente : Pessoa
    {
        public Docente(string nome, string id) : base(nome, id)
        {
        }
    }
    public class Titular : Docente
    {
        public Titular(string nome, string id) : base(nome, id)
        {
        }
    }
public class Assistente : Docente
{
    public Assistente(string nome, string id) : base(nome, id)
    {
    }
}
}