using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
        public class Estudante : Pessoa
        {
            private List<Avaliacao> lista_Notas;

            public Estudante(string nome, string id) : base(nome, id)
            {
                lista_Notas = new List<Avaliacao>();
            }
            public void Lancamento_Nota(Avaliacao av)
            {
                lista_Notas.Add(av);
            }
            public double Media_Final()
            {
                double Total = 0;
                foreach (Avaliacao av in lista_Notas)
                {
                    Total += av.Calcular_nota();
                }
                return Total;
            }

            public List<Avaliacao> Notas
            {
                get { return lista_Notas; }
            }
        }

    }

