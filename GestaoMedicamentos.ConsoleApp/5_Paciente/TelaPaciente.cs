
namespace GestaoMedicamentos.ConsoleApp._5_Paciente
{
    public class TelaPaciente
    {
        public RepositorioPaciente _repositorioPaciente = new RepositorioPaciente();
        public void AdicionarPaciente()
        {
            Paciente novoPaciente = new Paciente();

            Console.WriteLine("\n==============NOVO PACIENTE==============\n");

            Console.Write("Informe o nome do paciente: ");
            novoPaciente.Nome = Console.ReadLine();

            Console.Write("Informe o telefone: ");
            novoPaciente.Telefone = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            novoPaciente.Cpf = Console.ReadLine();

            _repositorioPaciente.Adicionar(novoPaciente);

            Console.WriteLine("\nPaciente cadastrado com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ListarPaciente()
        {
            Console.WriteLine("\n==============PACIENTES==============\n");

            List<Paciente> listaPaciente = _repositorioPaciente.SelecionarTodos();

            if (listaPaciente.Count == 0)
            {
                Console.WriteLine("\nNenhum paciente cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }
            foreach (Paciente paciente in listaPaciente)
            {
                Console.WriteLine($"ID do Paciente: {paciente.PacienteID}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.Cpf}");
                Console.WriteLine($"Teleofne: {paciente.Telefone}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarPaciente()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE PACIENTE==============\n");

            Console.Write("Digite o ID do Paciente que deseja atualizar: ");
            int pacienteId = int.Parse(Console.ReadLine());

            Paciente pacienteAtualizada = _repositorioPaciente.SelecionarPorId(pacienteId);
            if (pacienteAtualizada == null)
            {
                Console.WriteLine("\nPaciente não encontrada!");
                return;
            }
            Console.Write("Informe o novo nome: ");
            pacienteAtualizada.Nome = Console.ReadLine();

            Console.Write("Informe o novo cpf: ");
            pacienteAtualizada.Cpf = Console.ReadLine();

            Console.Write("Informe o novo telefone: ");
            pacienteAtualizada.Telefone = Console.ReadLine();

            if(_repositorioPaciente.Atualizar(pacienteAtualizada))
            {
                Console.WriteLine("\nPaciente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao atualizar o paciente!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ExcluirPaciente()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE PACIENTE==============\n");

            Console.Write("Digite o ID do Paciente que deseja deletar: ");
            int pacienteId = int.Parse(Console.ReadLine());

            if(_repositorioPaciente.Excluir(pacienteId))
            {
                Console.WriteLine("\nPaciente excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir paciente!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}
