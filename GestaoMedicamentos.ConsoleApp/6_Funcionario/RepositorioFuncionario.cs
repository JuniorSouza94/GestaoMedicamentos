using GestaoMedicamentos.ConsoleApp._1_Publico;


namespace GestaoMedicamentos.ConsoleApp._6_Funcionario
{
    public class RepositorioFuncionario : Listas
    {
        public List<Funcionario> SelecionarTodos()
        {
            return _listaFuncionario;
        }
        public void Adicionar(Funcionario funcionario)
        
        {
            _listaFuncionario.Add(funcionario);
        }
        public Funcionario SelecionarPorId(int id)
        {
            return _listaFuncionario.Find(f => f.RegistroId == id);
        }
        public bool Atualizar(Funcionario funcionarioAtualizado)
        {
            int indice = _listaFuncionario.FindIndex(f => f.RegistroId == funcionarioAtualizado.RegistroId);

            if (indice >= 0)
            {
                _listaFuncionario[indice] = funcionarioAtualizado;
                return true;
            }
            return false;
        }
        public bool Excluir(int id)
        {
            int indice = _listaFuncionario.FindIndex(f => f.RegistroId == id);
            if (indice >= 0)
            {
                _listaFuncionario.RemoveAt(indice);
                return true;
            }
            return false;
        }
    }
}
