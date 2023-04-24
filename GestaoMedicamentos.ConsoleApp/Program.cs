using GestaoMedicamentos.ConsoleApp._2_Requisicao;
using GestaoMedicamentos.ConsoleApp._3_Fornecedor;
using GestaoMedicamentos.ConsoleApp._4_Medicamento;
using GestaoMedicamentos.ConsoleApp._5_Paciente;
using GestaoMedicamentos.ConsoleApp._6_Funcionario;
using GestaoMedicamentos.ConsoleApp._7_Aquisicao;

namespace GestaoMedicamentos.ConsoleApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string _opcao;
            MenuFuncionario funcionario = new MenuFuncionario();
            MenuPaciente paciente = new MenuPaciente();
            MenuFornecedor fornecedor = new MenuFornecedor();
            MenuMedicamento medicamento = new MenuMedicamento();
            MenuAquisicao aquisicao = new MenuAquisicao();
            MenuRequisicao requisicao = new MenuRequisicao();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU PRINCIPAL =============");
                Console.WriteLine("[1] -> Menu Funcionário");
                Console.WriteLine("[2] -> Menu Paciente");
                Console.WriteLine("[3] -> Menu Fornecedor");
                Console.WriteLine("[4] -> Menu Medicamento");
                Console.WriteLine("[5] -> Menu Aquisição");
                Console.WriteLine("[6] -> Menu Requisição");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        funcionario.FuncionarioMenu();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        paciente.PacienteMenu();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        fornecedor.FornecedorMenu();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        medicamento.MedicamentoMenu();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        aquisicao.AquisicaoMenu();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        requisicao.RequisicaoMenu();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Até mais...");
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