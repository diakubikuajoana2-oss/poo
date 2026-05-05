using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros
{
    public class Veiculo
    {
        // Atributos
        private string matricula;
        private string marca;
        private string modelo;
        private int anoFabrico;
        private double quilometragem;

        // CONSTRUTOR SEM PARAMETROS
        public Veiculo()
        {
            matricula = "";
            marca = "";
            modelo = "";
            anoFabrico = 0;
            quilometragem = 0.0;
        }

        // CONSTRUTOR COM PARAMETROS
        public Veiculo(string mat, string mar, string mod, int ano, double km)
        {
            matricula = mat;
            marca = mar;
            modelo = mod;
            anoFabrico = ano;
            quilometragem = km;
        }

        // PROPRIEDADES (Get e Set)
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int AnoFabrico
        {
            get { return anoFabrico; }
            set { anoFabrico = value; }
        }

        public double Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }

        // METODOS
        public void ActualizarQuilometragem(double km)
        {
            quilometragem += km;
            Console.WriteLine("KM Atualizado!");
        }

        public void ApresentarDados()
        {
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + anoFabrico);
            Console.WriteLine("KM: " + quilometragem);
            Console.WriteLine("----------------------");
        }
    }
}