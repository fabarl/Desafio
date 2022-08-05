using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Passageiro : Usuario
    {
        Motorista moto = new Motorista();
        public string EndeInicio { get; set; }
        public string EndeFim { get; set; }
        protected int pag;
        public enum FormaPagamento
        {
            Pix,
            Dinheiro,
            CartaoDebito,
            CartaoCredito
        }
        public FormaPagamento FrmPag { get; set; }
        public void ChamarCorrida(string _ini, string _end)
        {
            EndeInicio = _ini;
            EndeFim = _end;
            Console.WriteLine("Corrida Solicitada ");
        }
        public void PagarCorrida(float vlr)
        {
            Console.Write("Escolha a Forma de Pagamento! [1]PIX, [2]Dinheiro, [3]Cartão Débito, [4]Cartão Crédito!");
            do
            {
                try
                {
                    pag = int.Parse(Console.ReadLine());
                    if(pag is <0 or > 4)
                    {
                        Console.Write("Forma inválida, Coloque Novamente: ");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Forma inválida, Coloque Novamente: ");
                    pag = 99;
                }
            } while (pag is < 0 or > 4);
            switch (pag)
            {
                case 1:
                    FrmPag = FormaPagamento.Pix;
                    break;
                case 2:
                    FrmPag = FormaPagamento.Dinheiro;
                    break;
                case 3:
                    FrmPag = FormaPagamento.CartaoDebito;
                    break;
                case 4:
                    FrmPag = FormaPagamento.CartaoCredito;
                    break;
                default:
                    Console.WriteLine("opção Inválida!");
                break;
            }
            moto.PagarMotorista(vlr);
        }
    }
}
