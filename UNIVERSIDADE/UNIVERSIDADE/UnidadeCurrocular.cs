using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
    public class Unidd_curricular
    {
        private string Nome_disciplina;
        private string cod_disciplina;
        private Docente professor;

        private List<Avaliacao> Tipos_Avaliacao;

      
        private List<Estudante> Alunos_Inscritos;

        public Unidd_curricular(string nome, string codigo)
        {
            Nome_disciplina = nome;
            cod_disciplina = codigo;
            Tipos_Avaliacao = new List<Avaliacao>();
            Alunos_Inscritos = new List<Estudante>();
        }

        public void Definir_Professor(Docente doc)
        {
            professor = doc;
        }

        public void Matricular_Aluno(Estudante aluno)
        {
            Alunos_Inscritos.Add(aluno);
        }

        public Estudante Pesquisar_Aluno(string id)
        {
            foreach (Estudante al in Alunos_Inscritos)
            {
                if (al.ID == id)
                    return al;
            }
            return null;
        }

        public void Pauta()
        {
      
            Console.WriteLine("   ==  PAUTA FINAL  ==");
            Console.WriteLine("Disciplina: " + Nome_disciplina);
            Console.WriteLine("----------------------------------");

      
            var ordenado = Alunos_Inscritos.OrderByDescending(a => a.Media_Final()).ToList();

            foreach (Estudante al in ordenado)
            {
                Console.WriteLine($"Aluno: {al.Nome} --> Média: {al.Media_Final():F2}");
            }
            Console.WriteLine("--------------------------------------\n");
        }
    }

}
