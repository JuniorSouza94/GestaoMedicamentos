using GestaoMedicamentos.ConsoleApp._1_Publico;
using System.Collections;

namespace GestaoMedicamentos.ConsoleApp._4_Medicamento
{
    public class RepositorioMedicamento : Listas
    {
        public List<Medicamento> SelecionarTodos()
        {
            return _listaMedicamentos;
        }
        public void Adicionar(Medicamento medicamento)
        {
            _listaMedicamentos.Add(medicamento);
        }
        public Medicamento SelecionarPorId(int id)
        {
            return _listaMedicamentos.Find(m => m.MedicamentoID == id);
        }
        public bool Atualizar(Medicamento medicamentoAtualizado)
        {
            int indice = _listaMedicamentos.FindIndex(m => m.MedicamentoID == medicamentoAtualizado.MedicamentoID);

            if (indice >= 0)
            {
                _listaMedicamentos[indice] = medicamentoAtualizado;
                return true;
            }
            return false;
        }
        public bool Excluir(int id)
        {
            int indice = _listaMedicamentos.FindIndex(m => m.MedicamentoID == id);
            if(indice >= 0)
            {
                _listaMedicamentos.RemoveAt(indice);
                return true;
            }
            return false;
        }
    }
}
