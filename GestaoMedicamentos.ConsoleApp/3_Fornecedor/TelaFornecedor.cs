using System;
using System.Collections;
using GestaoMedicamentos.ConsoleApp._4_Medicamento;


namespace GestaoMedicamentos.ConsoleApp._3_Fornecedor
{
    public class TelaFornecedor
    {
        public RepositorioFornecedor _repositorioFornecedor = new RepositorioFornecedor();

        public void AdicionarFornecedor()
        {
            Fornecedor novoFornecedor = new Fornecedor();

            Console.WriteLine("\n==============NOVO FORNECEDOR==============\n");
            
            Console.Write("Informe o nome do fornecedor: ");
            novoFornecedor.Nome = Console.ReadLine();

            Console.Write("Informe o CNPJ: ");
            novoFornecedor.Cnpj = Console.ReadLine();

            Console.Write("Informe o telefone: ");
            novoFornecedor.Telefone = Console.ReadLine();

            _repositorioFornecedor.Adicionar(novoFornecedor);

            Console.WriteLine("\nFornecedor cadastrada com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ListarFornecedores()
        {
            Console.WriteLine("\n==============FORNECEDORES==============\n");

            List<Fornecedor> listaFornecedores = _repositorioFornecedor.SelecionarTodos();

            if (listaFornecedores.Count == 0)
            {
                Console.WriteLine("\nNenhum fornecedor cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }
            foreach (Fornecedor fornecedor in listaFornecedores)
            {
                Console.WriteLine($"ID da requisição: {fornecedor.FornecedorID}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CNPJ: {fornecedor.Cnpj}");
                Console.WriteLine($"Telefone: {fornecedor.Telefone}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarFornecedores()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE FORNECEDORES==============\n");

            Console.Write("Digite o ID do fornecedor que deseja atualizar: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            Fornecedor fornecedorAtualizado = _repositorioFornecedor.SelecionarPorId(fornecedorId);
            if (fornecedorAtualizado == null)
            {
                Console.WriteLine("\nFornecedor não encontrada!");
                return;
            }

            Console.Write("Informe o novo nome: ");
            fornecedorAtualizado.Nome = Console.ReadLine();

            Console.Write("Informe o novo cnpj: ");
            fornecedorAtualizado.Cnpj = Console.ReadLine();

            Console.Write("Informe o novo telefone: ");
            fornecedorAtualizado.Telefone = Console.ReadLine();

            if (_repositorioFornecedor.Atualizar(fornecedorAtualizado))
            {
                Console.WriteLine("\nFornecedor atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao atualizar o fornecedor!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ExcluirFornecedor()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE FORNECEDOR==============\n");

            Console.Write("Digite o ID do Fornecedor que deseja excluir: ");
            int fornecedorId = int.Parse(Console.ReadLine());

            if (_repositorioFornecedor.Excluir(fornecedorId))
            {
                Console.WriteLine("\nFornecedor excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir fornecedor!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}
