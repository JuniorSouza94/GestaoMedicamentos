using GestaoMedicamentos.ConsoleApp._1_Publico;

namespace GestaoMedicamentos.ConsoleApp._3_Fornecedor
{
    public class RepositorioFornecedor : Listas
    {
        public List<Fornecedor> SelecionarTodos()
        {
            return _listaFornecedores;
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            _listaFornecedores.Add(fornecedor);
        }
        public Fornecedor SelecionarPorId(int id)
        {
            return _listaFornecedores.Find(f => f.FornecedorID == id);
        }
        public bool Atualizar(Fornecedor fornecedorAtualizado)
        {            
            int indice = _listaFornecedores.FindIndex(f => f.FornecedorID == fornecedorAtualizado.FornecedorID);

            if (indice >= 0)
            {
                _listaFornecedores[indice] = fornecedorAtualizado;
                return true;
            }
            return false;
        }
        public bool Excluir(int id)
        {
            int indice = _listaFornecedores.FindIndex(f => f.FornecedorID == id);
            if (indice >= 0)
            {
                _listaFornecedores.RemoveAt(indice);
                return true;
            }
            return false;
        }
    }
}
