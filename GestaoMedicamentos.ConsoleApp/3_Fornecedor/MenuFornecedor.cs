
namespace GestaoMedicamentos.ConsoleApp._3_Fornecedor
{
    public class MenuFornecedor
    {
        public void FornecedorMenu()
        {
            string _opcao;
            TelaFornecedor fornecedor = new TelaFornecedor();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU FORNECEDOR =============");
                Console.WriteLine("[1] -> Cadastrar Fornecedor");
                Console.WriteLine("[2] -> Visualizar Fornecedor");
                Console.WriteLine("[3] -> Atualizar Fornecedor");
                Console.WriteLine("[4] -> Deletar Fornecedor");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        fornecedor.AdicionarFornecedor();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        fornecedor.ListarFornecedores();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        fornecedor.AtualizarFornecedores();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        fornecedor.ExcluirFornecedor();
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
