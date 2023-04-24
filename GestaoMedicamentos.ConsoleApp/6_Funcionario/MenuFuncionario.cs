
namespace GestaoMedicamentos.ConsoleApp._6_Funcionario
{
    public class MenuFuncionario
    {
        public void FuncionarioMenu()
        {
            string _opcao;
            TelaFuncionario funcionario = new TelaFuncionario();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU FUNCIONÁRIO =============");
                Console.WriteLine("[1] -> Cadastrar Funcionário");
                Console.WriteLine("[2] -> Visualizar Funcionário");
                Console.WriteLine("[3] -> Atualizar Funcionário");
                Console.WriteLine("[4] -> Deletar Funcionário");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        funcionario.AdicionarFuncionario();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        funcionario.ListarFuncionario();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        funcionario.AtualizarFuncionario();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        funcionario.ExcluirFuncionario();
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
