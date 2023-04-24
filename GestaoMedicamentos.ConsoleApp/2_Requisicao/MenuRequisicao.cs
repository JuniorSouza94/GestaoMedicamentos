namespace GestaoMedicamentos.ConsoleApp._2_Requisicao
{
    public class MenuRequisicao
    {
        public void RequisicaoMenu()
        {
            string _opcao;
            TelaRequisicao requisicao = new TelaRequisicao();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU REQUISIÇÕES =============");
                Console.WriteLine("[1] -> Cadastrar Requisição");
                Console.WriteLine("[2] -> Visualizar Requisições");
                Console.WriteLine("[3] -> Atualizar Requisição");
                Console.WriteLine("[4] -> Deletar Requisição");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        requisicao.AdicionarRequisicao();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        requisicao.ListarRequisicoes();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        requisicao.AtualizarRequisicoes();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        requisicao.ExcluirRequisicoes();
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
