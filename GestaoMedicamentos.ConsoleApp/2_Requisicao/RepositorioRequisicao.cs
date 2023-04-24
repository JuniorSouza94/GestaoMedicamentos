using GestaoMedicamentos.ConsoleApp._1_Publico;
using GestaoMedicamentos.ConsoleApp._4_Medicamento;


namespace GestaoMedicamentos.ConsoleApp._2_Requisicao
{
    public class RepositorioRequisicao : Listas
    {
        public List<Requisicao> SelecionarTodos()
        {
            return _listaRequisicao;
        }

        public void Adicionar(Requisicao requisicao)
        {
            _listaRequisicao.Add(requisicao);
        }

        public Requisicao SelecionarPorId(int id)
        {
            return _listaRequisicao.Find(r => r.RequisicaoID == id);
        }

        public bool Atualizar(Requisicao requisicaoAtualizado)
        {
            int indice = _listaRequisicao.FindIndex(r => r.RequisicaoID == requisicaoAtualizado.RequisicaoID);

            if (indice >= 0)
            {
                _listaRequisicao[indice] = requisicaoAtualizado;
                return true;
            }

            return false;
        }

        public bool Excluir(int id)
        {
            int indice = _listaRequisicao.FindIndex(r => r.RequisicaoID == id);

            if (indice >= 0)
            {
                _listaRequisicao.RemoveAt(indice);
                return true;
            }

            return false;
        }
        public bool VerificarDisponibilidadeEstoque(Dictionary<Medicamento, int> estoque, Requisicao requisicaoAtualizado)
        {
            int quantidadeDisponivel;
            if (estoque.TryGetValue(requisicaoAtualizado.Medicamento, out quantidadeDisponivel))
            {
                if (requisicaoAtualizado.Quantidade > quantidadeDisponivel)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
