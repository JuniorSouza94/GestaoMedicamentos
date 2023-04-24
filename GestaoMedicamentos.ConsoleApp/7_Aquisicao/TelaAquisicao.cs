using GestaoMedicamentos.ConsoleApp._3_Fornecedor;
using GestaoMedicamentos.ConsoleApp._4_Medicamento;

namespace GestaoMedicamentos.ConsoleApp._7_Aquisicao
{
    public class TelaAquisicao
    {
        public readonly RepositorioAquisicao _repositorioAquisicao = new RepositorioAquisicao();
        private readonly RepositorioFornecedor _repositorioFornecedor = new RepositorioFornecedor();
        private readonly RepositorioMedicamento _repositorioMedicamento = new RepositorioMedicamento();

        public void AdicionarAquisicao()
        {
            Aquisicao novaAquisicao = new Aquisicao();

            Console.WriteLine("\n==============NOVA REQUISIÇÃO==============\n");

            Console.Write("Digite o ID do fornecedor: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = _repositorioFornecedor.SelecionarPorId(fornecedorId);
            if(fornecedor == null)
            {
                Console.WriteLine("\nFornecedor não encontrado!");
                return;
            }
            novaAquisicao.Fornecedor = fornecedor;

            Console.Write("Digite o ID do medicamento: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            Medicamento medicamento = _repositorioMedicamento.SelecionarPorId(medicamentoId);
            if (medicamento == null)
            {
                Console.WriteLine("\nMedicamento não encontrado!");
                return;
            }
            novaAquisicao.Medicamento = medicamento;

            novaAquisicao.DataAquisicao = DateTime.Now;

            Console.Write("Digite a quantidade requisitada: ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade <= 0)
            {
                Console.WriteLine("\nQuantidade inválida!");
                return;
            }
            novaAquisicao.QuantidadeMedicamento = quantidade;
            medicamento.QuantidadeDisponivel = novaAquisicao.QuantidadeMedicamento;

            _repositorioAquisicao.Adicionar(novaAquisicao);

            Console.WriteLine("\nAquisição cadastrada com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");

        }
        public void ListarAquisicao()
        {
            Console.WriteLine("\n==============AQUISIÇÃO==============\n");

            List<Aquisicao> listaAquisicao = _repositorioAquisicao.SelecionarTodos();

            if(listaAquisicao.Count == 0)
            {
                Console.WriteLine("\nNenhuma aquisição cadastrada!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }
            foreach(Aquisicao aquisicao in listaAquisicao)
            {
                Console.WriteLine($"ID da aquisição: {aquisicao.AquisicaoID}");
                Console.WriteLine($"ID Fornecedor: {aquisicao.Fornecedor.FornecedorID}");
                Console.WriteLine($"ID Medicamento: {aquisicao.Medicamento.MedicamentoID}");
                Console.WriteLine($"Data de aquisição: {aquisicao.DataAquisicao}");
                Console.WriteLine($"Quantidade: {aquisicao.QuantidadeMedicamento}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarAquisicao()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE AQUISIÇÕES==============\n");

            Console.Write("Digite o ID da aquisição que deseja atualizar: ");
            int aquisicaoId = int.Parse(Console.ReadLine());

            Aquisicao aquisicao = _repositorioAquisicao.SelecionarPorId(aquisicaoId);
            if(aquisicao == null)
            {
                Console.WriteLine("\nAquisição não encontrada!");
                return;
            }

            Console.Write("Digite o ID do medicamento: ");
            int medicamentoId = int.Parse(Console.ReadLine());

            Medicamento medicamento = _repositorioMedicamento.SelecionarPorId(medicamentoId);
            if(medicamento == null)
            {
                Console.WriteLine("\nMedicamento não encontrado!");
                return;
            }

            Console.Write("Digite o ID do fornecedor: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = _repositorioFornecedor.SelecionarPorId(fornecedorId);
            if(fornecedor == null)
            {
                Console.WriteLine("\nFornecedor não encontrado!");
                return;
            }

            aquisicao.DataAquisicao = DateTime.Now;

            Console.Write("Digite a quantidade requisitada: ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade <= 0)
            {
                Console.WriteLine("\nQuantidade inválida!");
                return;
            }

            aquisicao.QuantidadeMedicamento += quantidade;

            if(_repositorioAquisicao.Atualizar(aquisicao))
            {
                Console.WriteLine("\nAquisição atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao atualizar aquisição!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    
        public void ExcluirAquisicao()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE AQUISIÇÕES==============\n");

            Console.Write("Digite o ID da aquisição que deseja excluir: ");
            int aquisicaooId = int.Parse(Console.ReadLine());

            if (_repositorioAquisicao.Excluir(aquisicaooId))
            {
                Console.WriteLine("\nAquisição excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir aquisição!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}
