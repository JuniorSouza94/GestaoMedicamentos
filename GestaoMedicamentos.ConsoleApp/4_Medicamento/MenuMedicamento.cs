using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMedicamentos.ConsoleApp._4_Medicamento
{
    public class MenuMedicamento
    {
        public void MedicamentoMenu()
        {
            string _opcao;
            TelaMedicamento medicamento = new TelaMedicamento();

            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU MEDICAMENTO =============");
                Console.WriteLine("[1] -> Cadastrar Medicamento");
                Console.WriteLine("[2] -> Visualizar Medicamento");
                Console.WriteLine("[3] -> Atualizar Medicamento");
                Console.WriteLine("[4] -> Deletar Medicamento");
                Console.WriteLine("[5] -> Medicamentos Mais Retirados");
                Console.WriteLine("[6] -> Medicamentos Em Falta");
                Console.WriteLine("[7] -> Medicamentos Com Pouca Quantidade");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        medicamento.AdicionarMedicamento();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        medicamento.ListarMedicamento();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        medicamento.AtualizarMedicamento();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        medicamento.ExcluirMedicamento();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        medicamento.MostrarMedicamentosMaisRetirados();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        medicamento.MedicamentosEmFalta();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        medicamento.MedicamentosComPoucaQuantidade();
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
