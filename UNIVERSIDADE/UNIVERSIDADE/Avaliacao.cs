using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
    public abstract class  Avaliacao : IAvaliavel
    {
        protected double valor_nota;
        protected double peso_media;

        public Avaliacao(double nota, double peso)
        {
            this.valor_nota = nota;
            this.peso_media = peso;
        }

        public abstract double Calcular_nota();
    }

    public class Teste : Avaliacao
    {
        public Teste(double nota, double peso) : base(nota, peso) { }

        public override double Calcular_nota()
        {
            return valor_nota * peso_media;
        }
    }

    public class Projecto : Avaliacao
    {
        public Projecto(double nota, double peso) : base(nota, peso) { }

        public override double Calcular_nota()
        {
            return valor_nota * peso_media;
        }
    }

    public class Exame_Final : Avaliacao
    {
        public Exame_Final(double nota, double peso) : base(nota, peso) { }

        public override double Calcular_nota()
        {
            return valor_nota * peso_media;
        }
    }
}
