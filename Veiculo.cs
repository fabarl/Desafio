using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Veiculo : Motorista
    {
        public string Modelo;
        public string Placa;
        public string Cor;
        public void CadastroVeiculo(string _modelo, string _placa, string _cor)
        {
            Modelo = _modelo;
            Placa = _placa;
            Cor = _cor;
            Console.WriteLine($"Veiculo {Modelo},{Placa},{Cor} Cadastrado com sucesso!");
        }
    }
}
