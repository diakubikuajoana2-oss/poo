using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Veiculo carro1 = new Veiculo("ABC-1234", "Toyota", "Corolla", 2018, 45000.5);

            
            Veiculo carro2 = new Veiculo();
            carro2.Matricula = "XYZ-9876";
            carro2.Marca = "Honda";
            carro2.Modelo = "Civic";
            carro2.AnoFabrico = 2020;
            carro2.Quilometragem = 20000.0;

            Veiculo carro3 = new Veiculo("LMN-4567", "Ford", "Fiesta", 2015, 80000.0);


            
            Console.WriteLine(" DADOS CADASTRADOS:");
            carro1.ApresentarDados();
            carro2.ApresentarDados();
            carro3.ApresentarDados();


            Console.WriteLine("VIAGEM REALIZADA:");
            carro1.ActualizarQuilometragem(150);
            carro2.ActualizarQuilometragem(300);


            Console.WriteLine(">> DADOS FINAIS:");
            carro1.ApresentarDados();
            carro2.ApresentarDados();
            Console.WriteLine("Enter para sair :");

            Console.ReadLine();
        }
    }
}