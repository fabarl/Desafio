using System;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opc = "Ocupado";
            string EndOrigem;
            string EndDestino;
            int star = 99;
            Motorista Mot = new Motorista();
            Veiculo Vei = new Veiculo();
            Passageiro Pass = new Passageiro();
            Corrida corrida = new Corrida();

            Pass.CadastroUsuario("Fabiano","6696291058", "Passageiro");
            Mot.CadastroUsuario("José", "669999999","Motorista");
            Vei.CadastroVeiculo("Lanborghini","BR999","Preto");

            Console.Clear();

            Console.Write("informe o Endereço de Origem: ");
            EndOrigem = Console.ReadLine();
            Console.Write("informe o Endereço de Destino: ");
            EndDestino = Console.ReadLine();
            Pass.ChamarCorrida(EndOrigem,EndDestino);

            while (Mot.AceitarCorrida(Opc) != true)
            {
                    Opc = "Livre";
            }
            corrida.IniciarCorrida(EndOrigem,EndDestino,Pass.Nome,Mot.Nome,150);
            corrida.FinalizarCorrida();
            Pass.PagarCorrida(150);
            Console.Write("Qualifique o Motorista com estrelas de 0 a 5:");
            do
            {
                
                try
                {
                    star = int.Parse(Console.ReadLine());
                    if(star <0 || star > 5)
                    {
                        Console.Write("Valor Inválido, informe Novamente:");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Tipo de dado inválido, Coloque Novamente:");
                    star = 99;
                }
            } while (star is < 0 or > 5);
            Mot.AvaliarEstrela(star);
            Console.Write("Qualifique o Passageiro com estrelas de 0 a 5:");
            do
            {

                try
                {
                    star = int.Parse(Console.ReadLine());
                    if (star < 0 || star > 5)
                    {
                        Console.Write("Valor Inválido, informe Novamente:");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Tipo de dado inválido, Coloque Novamente:");
                    star = 99;
                }

            } while (star is < 0 or > 5);
            Pass.AvaliarEstrela(star);
        }
    }
}
