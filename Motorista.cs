using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Motorista : Usuario
    {
        protected float SaldoConta;
 
        
        public bool AceitarCorrida(string _info)
        {
            bool _opc
;            if (_info == "Livre")
            {
                Console.WriteLine("Corrida Aceita!");
                _opc = true;
            }
            else
            {
                Console.WriteLine("Corrida Recusada! Procurando outro Motorista!");
                _opc = false;
             }
                return _opc;
        }
        public void PagarMotorista(float saldo)
        {
            SaldoConta = SaldoConta + saldo;
            Console.WriteLine("Pagamento Realizado com Sucesso!");
        }
                
    }
}
