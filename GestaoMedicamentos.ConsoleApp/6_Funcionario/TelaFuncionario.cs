using System.Collections;

namespace GestaoMedicamentos.ConsoleApp._6_Funcionario
{
    public class TelaFuncionario
    {
        public RepositorioFuncionario _repositorioFuncionario = new RepositorioFuncionario();
        public void AdicionarFuncionario()
        {
            Funcionario novoFuncionario = new Funcionario();

            Console.WriteLine("\n==============NOVO FUNCIONÁRIO==============\n");
            
            Console.Write("Informe o nome do funcionário: ");
            novoFuncionario.Nome = Console.ReadLine();

            Console.Write("Informe o telefone: ");
            novoFuncionario.Telefone = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            novoFuncionario.Cpf = Console.ReadLine();

            _repositorioFuncionario.Adicionar(novoFuncionario);

            Console.WriteLine("\nFuncionário cadastrado com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ListarFuncionario()
        {
            Console.WriteLine("\n==============FUNCIONÁRIO==============\n");

            List<Funcionario> listaFuncionario = _repositorioFuncionario.SelecionarTodos();

            if (listaFuncionario.Count == 0)
            {
                Console.WriteLine("\nNenhum funcionário cadastrado!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                return;
            }
            foreach(Funcionario funcionario in listaFuncionario)
            {
                Console.WriteLine($"ID do Funcionário: {funcionario.RegistroId}");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"CPF: {funcionario.Cpf}");
                Console.WriteLine($"Teleofne: {funcionario.Telefone}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void AtualizarFuncionario()
        {
            Console.WriteLine("\n==============ATUALIZAÇÃO DE FUNCIONÁRIO==============\n");

            Console.Write("Digite o ID do Funcionário que deseja atualizar: ");
            int funcionarioId = int.Parse(Console.ReadLine());

            Funcionario funcionarioAtualizado = _repositorioFuncionario.SelecionarPorId(funcionarioId);
            if(funcionarioAtualizado == null)
            {
                Console.WriteLine("\nFuncionário não encontrada!");
                return;
            }
            Console.Write("Informe o novo nome: ");
            funcionarioAtualizado.Nome = Console.ReadLine();

            Console.Write("Informe o novo cpf: ");
            funcionarioAtualizado.Cpf = Console.ReadLine();

            Console.Write("Informe o novo telefone: ");
            funcionarioAtualizado.Telefone = Console.ReadLine();

            if(_repositorioFuncionario.Atualizar(funcionarioAtualizado))
            {
                Console.WriteLine("\nFuncionário atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao funcionário o paciente!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
        public void ExcluirFuncionario()
        {
            Console.WriteLine("\n==============EXCLUSÃO DE FUNCIONÁRIO==============\n");

            Console.Write("Digite o ID do Funcionário que deseja deletar: ");
            int funcionarioId = int.Parse(Console.ReadLine());

            if(_repositorioFuncionario.Excluir(funcionarioId))
            {
                Console.WriteLine("\nFuncionário excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro ao excluir funcionário!");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        }
    }
}
