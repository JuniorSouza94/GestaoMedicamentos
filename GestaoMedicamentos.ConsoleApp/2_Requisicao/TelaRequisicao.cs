using GestaoMedicamentos.ConsoleApp._4_Medicamento;
using GestaoMedicamentos.ConsoleApp._5_Paciente;
using GestaoMedicamentos.ConsoleApp._6_Funcionario;

namespace GestaoMedicamentos.ConsoleApp._2_Requisicao
{
    public class TelaRequisicao
    {
        public RepositorioRequisicao _repositorioRequisicao = new RepositorioRequisicao();
        private readonly RepositorioPaciente _repositorioPaciente = new RepositorioPaciente();
        private readonly RepositorioMedicamento _repositorioMedicamento = new RepositorioMedicamento();
        private readonly RepositorioFuncionario _repositorioFuncionario = new RepositorioFuncionario();

        public void AdicionarRequisicao()
        {
            Console.WriteLine("\n==============NOVA REQUISIÇÃO==============\n");

            Console.Write("Digite o ID do paciente: ");
            int pacienteId = int.Parse(Console.ReadLine());

            Paciente paciente = _repositorioPaciente.SelecionarPorId(pacienteId);
            if (paciente == null)
            {
                Console.WriteLine("\nPaciente não encontrado!");
                return;
            }

            Console.Write("Digite o ID do medicamento: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            Medicamento medicamento = _repositorioMedicamento.SelecionarPorId(medicamentoId);
            if (medicamento == null)
            {
                Console.WriteLine("\nMedicamento não encontrado!");
                return;
            }

            Console.Write("Digite o ID do funcionário que realizou a requisição: ");
            int funcionarioId = int.Parse(Console.ReadLine());

            Funcionario funcionario = _repositorioFuncionario.SelecionarPorId(funcionarioId);
            if (funcionario == null)
            {
                Console.WriteLine("\nFuncionário não encontrado!");
                return;
            }

            Console.Write("Digite a quantidade requisitada: ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade <= 0)
            {
                Console.WriteLine("\nQuantidade inválida!");
                return;
            }

            if (quantidade > medicamento.QuantidadeDisponivel)
            {
                Console.WriteLine("\nQuantidade insuficiente no estoque!");
                return;
            }

            Requisicao requisicao = new Requisicao(paciente, medicamento, funcionario, quantidade);
            _repositorioRequisicao.Adicionar(requisicao);

            medicamento.QuantidadeDisponivel -= quantidade;
            _repositorioMedicamento.Atualizar(medicamento);

            Console.WriteLine("\nRequisição cadastrada com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");

        }
        public void ListarRequisicoes()
        {
            Console.WriteLine("\n==============REQUISIÇÕES==============\n");

            List<Requisicao> listaRequisicoes = _repositorioRequisicao.SelecionarTodos();

            if (listaRequisicoes.Count == 0)
            {
                Console.WriteLine("\nNenhuma requisição cadastrada!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }

            foreach (Requisicao requisicao in listaRequisicoes)
            {
                Console.WriteLine($"Paciente: {requisicao.Paciente.Nome}");
                Console.WriteLine($"Medicamento: {requisicao.Medicamento.Nome}");
                Console.WriteLine($"Funcionário: {requisicao.Funcionario.Nome}");
                Console.WriteLine($"Quantidade: {requisicao.Quantidade}");
                Console.WriteLine("------------------------------------\n");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarRequisicoes()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE REQUISIÇÕES==============\n");

            Console.Write("Digite o ID da requisição que deseja atualizar: ");
            int requisicaoId = int.Parse(Console.ReadLine());

            Requisicao requisicao = _repositorioRequisicao.SelecionarPorId(requisicaoId);
            if (requisicao == null)
            {
                Console.WriteLine("\nRequisição não encontrada!");
                return;
            }

            Console.Write("Digite o ID do paciente: ");
            int pacienteId = int.Parse(Console.ReadLine());

            Paciente paciente = _repositorioPaciente.SelecionarPorId(pacienteId);
            if (paciente == null)
            {
                Console.WriteLine("\nPaciente não encontrado!");
                return;
            }

            Console.Write("Digite o ID do medicamento: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            Medicamento medicamento = _repositorioMedicamento.SelecionarPorId(medicamentoId);
            if (medicamento == null)
            {
                Console.WriteLine("\nMedicamento não encontrado!");
                return;
            }

            Console.Write("Digite o ID do funcionário que realizou a requisição: ");
            int funcionarioId = int.Parse(Console.ReadLine());

            Funcionario funcionario = _repositorioFuncionario.SelecionarPorId(funcionarioId);
            if (funcionario == null)
            {
                Console.WriteLine("\nFuncionário não encontrado!");
                return;
            }

            Console.Write("Digite a nova quantidade requisitada: ");
            int quantidade = int.Parse(Console.ReadLine());

            Requisicao requisicaoAtualizado = new Requisicao(paciente, medicamento, funcionario, quantidade);

            if (_repositorioRequisicao.Atualizar(requisicaoAtualizado))
            {
                Console.WriteLine("\nRequisição atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao atualizar requisição!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ExcluirRequisicoes()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE REQUISIÇÕES==============\n");

            Console.Write("Digite o ID da requisição que deseja excluir: ");
            int requisicaoId = int.Parse(Console.ReadLine());

            if (_repositorioRequisicao.Excluir(requisicaoId))
            {
                Console.WriteLine("\nRequisição excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir requisição!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}
