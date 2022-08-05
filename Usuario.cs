using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Usuario
    {
        public string Nome { get; set; }
        protected string Telefone { get; set; }
        protected int Estrelas { get; set; }
        public string TipoUsuario { get; set; }
        public void AvaliarEstrela(int QtdEstrela)
        {
            Estrelas = Estrelas + QtdEstrela;
        }

        public void CadastroUsuario(string nome, string telefone, string tipo)
        {
            Nome = nome;
            Telefone = telefone;
            TipoUsuario = tipo;
            Console.WriteLine($"Cadastro de {nome}, {tipo} Realizado com Sucesso!");
        }

    }
}
