
using GestaoMedicamentos.ConsoleApp._1_Publico;

namespace GestaoMedicamentos.ConsoleApp._5_Paciente
{
    public class RepositorioPaciente : Listas
    {
        public List<Paciente> SelecionarTodos()
        {
            return _listaPaciente;
        }
        public void Adicionar(Paciente paciente)
        {
            _listaPaciente.Add(paciente);
        }
        public Paciente SelecionarPorId(int id)
        {
            return _listaPaciente.Find(p => p.PacienteID == id);
        }
        public bool Atualizar(Paciente pacienteAtualizado)
        {
            int indice = _listaPaciente.FindIndex(p => p.PacienteID == pacienteAtualizado.PacienteID);
            
            if (indice >= 0)
            {
                _listaPaciente[indice] = pacienteAtualizado;
                return true;
            }
            return false;
        }
        public bool Excluir(int id)
        {
            int indice = _listaPaciente.FindIndex(p => p.PacienteID == id);
            if (indice >= 0)
            {
                _listaPaciente.RemoveAt(indice);
                return true;
            }
            return false;
        }
    }
}
