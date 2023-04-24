using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMedicamentos.ConsoleApp._5_Paciente
{
    public class MenuPaciente
    {
        public void PacienteMenu()
        {
            string _opcao;
            TelaPaciente paciente = new TelaPaciente();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU PACIENTE =============");
                Console.WriteLine("[1] -> Cadastrar Paciente");
                Console.WriteLine("[2] -> Visualizar Paciente");
                Console.WriteLine("[3] -> Atualizar Paciente");
                Console.WriteLine("[4] -> Deletar Paciente");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        paciente.AdicionarPaciente();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        paciente.ListarPaciente();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        paciente.AtualizarPaciente();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        paciente.ExcluirPaciente();
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
