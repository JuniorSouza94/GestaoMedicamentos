namespace GestaoMedicamentos.ConsoleApp
{
    public class Paciente
    {
        private static int _proximoId = 1;
        public int PacienteID { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Paciente()
        {
            PacienteID = _proximoId;
            _proximoId++;
        }
    }
}