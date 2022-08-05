using System;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opc = "Ocupado";
            int vrf;
            string EndOrigem;
            string EndDestino;
            int star = 99;
            Motorista Mot = new Motorista();
            Veiculo Vei = new Veiculo();
            Passageiro Pass = new Passageiro();
            Corrida corrida = new Corrida();
            // Cadastro dos dados no Aplicativo
            Pass.CadastroUsuario("Fabiano","6696291058", "Passageiro");
            Mot.CadastroUsuario("José", "669999999","Motorista");
            Vei.CadastroVeiculo("Lanborghini","BR999","Preto");

            Console.Clear();
            //Inicio da Corrida
            Console.WriteLine($" Bem Vindo {Pass.Nome}, Informe os dados para iniciarmos:"); 
            Console.Write("informe o Endereço de Origem: ");
            EndOrigem = Console.ReadLine();
            Console.Write("informe o Endereço de Destino: ");
            EndDestino = Console.ReadLine();

            Console.Clear();
            //Encontrar um Motorista
            Pass.ChamarCorrida(EndOrigem,EndDestino);
            //Motorista aceita ou não
            
            do
            {
                Console.WriteLine($" Origem: {EndOrigem} - Destino: {EndDestino}");
                Console.Write($"Motorista {Mot.Nome} Deseja aceitar a Corrida? ");
                Console.Write($"[1] Aceitar - [2] Negar : ");
                try
                {
                    vrf = int.Parse(Console.ReadLine());
                    if (vrf is < 1 or > 2)
                        Console.Write("Insira um opção Válida: ");
                    else
                    {
                        if(vrf == 1)
                            Opc = "Livre";
                    }                        
                }
                catch (Exception)
                {
                    Console.Write("Opção inválida! Insira novamente: ");
                }                
            } while (Mot.AceitarCorrida(Opc) != true);
            //Inicia a Corrida
            corrida.IniciarCorrida(EndOrigem, EndDestino, Pass.Nome, Mot.Nome, 50);
            //finaliza a Corrida
            corrida.FinalizarCorrida();
            //Paga a Corrida
            Pass.PagarCorrida(50);
            //Qualifica a corrida
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
