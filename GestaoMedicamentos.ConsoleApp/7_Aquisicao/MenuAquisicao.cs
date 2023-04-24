using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMedicamentos.ConsoleApp._7_Aquisicao
{
    public class MenuAquisicao
    {
        public void AquisicaoMenu()
        {
            string _opcao;
            TelaAquisicao aquisicao = new TelaAquisicao();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU AQUISIÇÃO =============");
                Console.WriteLine("[1] -> Cadastrar Aquisição");
                Console.WriteLine("[2] -> Visualizar Aquisição");
                Console.WriteLine("[3] -> Atualizar Aquisição");
                Console.WriteLine("[4] -> Deletar Aquisição");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        aquisicao.AdicionarAquisicao();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        aquisicao.ListarAquisicao();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        aquisicao.AtualizarAquisicao();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        aquisicao.ExcluirAquisicao();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Aperte qualquer tecla para retornar.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        Console.WriteLine("Aperte qualquer tecla para retornar.");
                        Console.ReadKey();
                        break;
                }
            } while (_opcao != "0");

        }
    }
}
