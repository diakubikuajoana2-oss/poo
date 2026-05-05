using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDADE
{
    class Program
    {
        static void Main(string[] args)
        {

            Unidd_curricular materia = new Unidd_curricular("Logica de Programacao", "LP001");

          
            Titular prof = new Titular("Professor Kumbi Manuel", "T01");
            materia.Definir_Professor(prof);

         
            Console.WriteLine("========================================");
            Console.WriteLine("         SISTEMA DA UNIVERSIDADE        ");
            Console.WriteLine("========================================");
            Console.WriteLine("Unidade Curricular: Logica de Programacao");
            Console.WriteLine("Codigo: LP01");
            Console.WriteLine("Docente : Professor Kumbi Manuel");
            Console.WriteLine("Categoria: Titular");
            
            int opcaoEscolhida;

            do
            {
              
                Console.WriteLine("===== CONTROLE DE NOTAS =====");
                Console.WriteLine("1 - Cadastrar Novo Aluno");
                Console.WriteLine("2 - Lancar Notas");
                Console.WriteLine("3 - Ver Pauta Final");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite sua opcao: ");

                opcaoEscolhida = int.Parse(Console.ReadLine());

               
                switch (opcaoEscolhida)
                {
                    case 1:
                        Console.Write("Nome do Aluno: ");
                        string n = Console.ReadLine();
                        Console.Write("Seu codigo(id): ");
                        string i = Console.ReadLine();

                        Estudante novo = new Estudante(n, i);
                        materia.Matricular_Aluno(novo);
                        Console.WriteLine("Cadastrado feito com sucesso.\n");
                        break;

                    case 2:
                        Console.Write("Informe o codigo(id) do aluno: ");
                        string busca = Console.ReadLine();

                        Estudante al = materia.Pesquisar_Aluno(busca);

                        if (al != null)
                        {
                            Console.Write("Digite a Nota do Teste: ");
                            double nt = double.Parse(Console.ReadLine());
                            Console.Write("Digite a Nota do Projecto: ");
                            double np = double.Parse(Console.ReadLine());
                            Console.Write("Digite a Nota do Exame: ");
                            double ne = double.Parse(Console.ReadLine());

                            al.Lancamento_Nota(new Teste(nt, 0.3));
                            al.Lancamento_Nota(new Projecto(np, 0.3));
                            al.Lancamento_Nota(new Exame_Final(ne, 0.4));
                            Console.WriteLine(" Notas lancadas com exito!\n");
                        }
                        else
                        {
                            Console.WriteLine("Deculpe! O Aluno nao foi encontrado.\n");
                        }
                        break;

                    case 3:
                        materia.Pauta();
                        break;

                    case 0:
                        Console.WriteLine("Fechar o sistema...");
                        break;

                    default:
                        Console.WriteLine("esta Opcao e invalida!\n");
                        break;
                }

            } while (opcaoEscolhida != 0);

        }
    }
}