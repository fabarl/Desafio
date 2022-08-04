using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Corrida
    {
        protected string PassageiroC;
        protected string MotoristaC;
        protected string EndInicial;
        protected string EndFinal;
        protected float Valor;

        
        public void IniciarCorrida(string EndIni, string EndFim, string _passageiro, string _motorista, float vlr)
        {
            EndInicial = EndIni;
            EndFinal = EndFim;
            PassageiroC = _passageiro;
            MotoristaC = _motorista;
            Valor = vlr;
            Console.WriteLine( "Dados da Corrida Iniciada." );
            Console.WriteLine($" Passageiro = {PassageiroC}");
            Console.WriteLine($" Motorista = {MotoristaC}");
            Console.WriteLine($" Endereço de Origem = {EndInicial}");
            Console.WriteLine($" Endereço Final = {EndFinal}");
            Console.WriteLine($" Valor = {Valor}");
        }
        public void FinalizarCorrida()
        {
            Console.WriteLine("Corrida Finalisada");
   
        }

    }
}
