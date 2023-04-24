using GestaoMedicamentos.ConsoleApp._1_Publico;
using System.Collections;

namespace GestaoMedicamentos.ConsoleApp._7_Aquisicao
{
    public class RepositorioAquisicao : Listas
    {
        public List<Aquisicao> SelecionarTodos()
        {
            return _listAquisicao;
        }
        public Aquisicao SelecionarPorId(int id)
        {
            return _listAquisicao.Find(a => a.AquisicaoID == id);
        }
        public void Adicionar(Aquisicao aquisicao)
        {
            _listAquisicao.Add(aquisicao);
        }
        public bool Atualizar(Aquisicao aquisicaoAtualizado)
        {
            int indice = _listAquisicao.FindIndex(a => a.AquisicaoID == aquisicaoAtualizado.AquisicaoID);                

            if (indice >= 0)
            {
                _listAquisicao[indice] = aquisicaoAtualizado;
                return true;
            }

            return false;
        }

        public bool Excluir(int id)
        {
            int indice = _listAquisicao.FindIndex(a => a.AquisicaoID == id);

            if (indice >= 0)
            {
                _listAquisicao.RemoveAt(indice);
                return true;
            }

            return false;
        }
    }
}
