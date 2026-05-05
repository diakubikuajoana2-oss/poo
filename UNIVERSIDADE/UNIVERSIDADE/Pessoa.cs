using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
        public abstract class Pessoa
        {
            protected string nome;
            protected string cod;
            public Pessoa(string nome, string id)
            {
                this.nome = nome;
                this.cod = id;
            }
            public string Nome
            {
                get { return nome; }
            }
            public string ID
            {
                get { return cod; }
            }
        }

    }

