using System.Collections;
using GestaoMedicamentos.ConsoleApp._2_Requisicao;
using GestaoMedicamentos.ConsoleApp._3_Fornecedor;

namespace GestaoMedicamentos.ConsoleApp._4_Medicamento
{
    public class TelaMedicamento
    {
        public RepositorioMedicamento _repositorioMedicamento = new RepositorioMedicamento();
        private readonly RepositorioFornecedor _repositorioFornecedor = new RepositorioFornecedor();

        public void AdicionarMedicamento()
        {
            Medicamento novoMedicamento = new Medicamento();

            Console.WriteLine("\n==============NOVO MEDICAMENTO==============\n");

            Console.Write("Informe o nome: ");
            novoMedicamento.Nome = Console.ReadLine();

            Console.Write("Informe a descrição: ");
            novoMedicamento.Descricao = Console.ReadLine();

            Console.Write("Informe a quantidade: ");
            novoMedicamento.QuantidadeDisponivel = int.Parse(Console.ReadLine());

            Console.Write("Digite o ID do Fornecedor: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            Fornecedor fornecedorSelecionado = _repositorioFornecedor.SelecionarPorId(fornecedorId);

            if (fornecedorSelecionado == null)
            {
                Console.WriteLine("\nFornecedor não encontrado!");
                return;
            }
            novoMedicamento.Fornecedor = fornecedorSelecionado;

            _repositorioMedicamento.Adicionar(novoMedicamento);

            Console.WriteLine("\nRequisição cadastrada com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");

        }
        public void ListarMedicamento()
        {
            Console.WriteLine("\n==============MEDICAMENTOS==============\n");

            List<Medicamento> listaMedicamento = _repositorioMedicamento.SelecionarTodos();

            if (listaMedicamento.Count == 0)
            {
                Console.WriteLine("\nNenhuma fornecedor cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }

            foreach (Medicamento medicamento in listaMedicamento)
            {
                Console.WriteLine($"ID da medicamentoAtualizado: {medicamento.MedicamentoID}");
                Console.WriteLine($"Nome: {medicamento.Nome}");
                Console.WriteLine($"Descrição: {medicamento.Descricao}");
                Console.WriteLine($"Quantidade: {medicamento.QuantidadeDisponivel}");
                Console.WriteLine($"Fornecedor: {medicamento.Fornecedor.FornecedorID}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarMedicamento()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE MEDICAMENTOS==============\n");

            Console.Write("Digite o ID da medicamento que deseja atualizar: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            Medicamento medicamentoAtualizado = _repositorioMedicamento.SelecionarPorId(medicamentoId);

            if (medicamentoAtualizado == null)
            {
                Console.WriteLine("\nMedicamento não encontrada!");
                return;
            }
            Console.Write("Informe o nome: ");
            medicamentoAtualizado.Nome = Console.ReadLine();

            Console.Write("Informe a descrição: ");
            medicamentoAtualizado.Descricao = Console.ReadLine();

            Console.Write("Informe a quantidade: ");
            medicamentoAtualizado.QuantidadeDisponivel = int.Parse(Console.ReadLine());

            Console.Write("Digite o ID do Fornecedor: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            Fornecedor fornecedorSelecionado = _repositorioFornecedor.SelecionarPorId(fornecedorId);

            if (fornecedorSelecionado == null)
            {
                Console.WriteLine("\nFornecedor não encontrado!");
                return;
            }

            medicamentoAtualizado.Fornecedor = fornecedorSelecionado;

            _repositorioMedicamento.Atualizar(medicamentoAtualizado);

            if (_repositorioMedicamento.Atualizar(medicamentoAtualizado))
            {
                Console.WriteLine("\nRequisição atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao atualizar medicamento!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");

        }
        public void ExcluirMedicamento()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE MEDICAMENTO==============\n");

            Console.Write("Digite o ID da medicamento que deseja excluir: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            if (_repositorioMedicamento.Excluir(medicamentoId))
            {
                Console.WriteLine("\nMedicamento excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir medicamento!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void MostrarMedicamentosMaisRetirados()
        {
            Console.WriteLine("\n==============MEDICAMENTOS MAIS RETIRADOS==============\n");

            List<Medicamento> listaMedicamento = _repositorioMedicamento.SelecionarTodos();

            if (listaMedicamento.Count == 0)
            {
                Console.WriteLine("\nNenhum medicamento cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }

            listaMedicamento = listaMedicamento.OrderByDescending(m => m.QuantidadeRetiradas).ToList();

            foreach (Medicamento medicamento in listaMedicamento)
            {
                Console.WriteLine($"Nome: {medicamento.Nome}");
                Console.WriteLine($"Descrição: {medicamento.Descricao}");
                Console.WriteLine($"Quantidade: {medicamento.QuantidadeDisponivel}");
                Console.WriteLine($"Fornecedor: {medicamento.Fornecedor.Nome}");
                Console.WriteLine($"Número de Retiradas: {medicamento.QuantidadeRetiradas}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }

        public void MedicamentosEmFalta()
        {
            Console.WriteLine("\n==============MEDICAMENTOS EM FALTA==============\n");

            List<Medicamento> listaMedicamento = _repositorioMedicamento.SelecionarTodos();

            if (listaMedicamento.Count == 0)
            {
                Console.WriteLine("\nNenhum medicamento cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }

            listaMedicamento = listaMedicamento.Where(m => m.QuantidadeDisponivel == 0).ToList();

            foreach (Medicamento medicamento in listaMedicamento)
            {
                Console.WriteLine($"Nome: {medicamento.Nome}");
                Console.WriteLine($"Descrição: {medicamento.Descricao}");
                Console.WriteLine($"Quantidade: {medicamento.QuantidadeDisponivel}");
                Console.WriteLine($"Fornecedor: {medicamento.Fornecedor.Nome}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void MedicamentosComPoucaQuantidade()
        {
            Console.WriteLine("\n==============MEDICAMENTOS COM POUCO ESTOQUE==============\n");

            List<Medicamento> listaMedicamento = _repositorioMedicamento.SelecionarTodos();

            if (listaMedicamento.Count == 0)
            {
                Console.WriteLine("\nNenhum medicamento cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }
            listaMedicamento = listaMedicamento.Where(m => m.QuantidadeDisponivel <= 5).ToList();

            foreach (Medicamento medicamento in listaMedicamento)
            {
                Console.WriteLine($"Nome: {medicamento.Nome}");
                Console.WriteLine($"Descrição: {medicamento.Descricao}");
                Console.WriteLine($"Quantidade: {medicamento.QuantidadeDisponivel}");
                Console.WriteLine($"Fornecedor: {medicamento.Fornecedor.Nome}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}