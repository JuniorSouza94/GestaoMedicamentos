namespace GestaoMedicamentos.ConsoleApp
{
    public class Funcionario
    {
        private static int _proximoId = 1;
        public int RegistroId { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Funcionario()
        {
            RegistroId = _proximoId;
            _proximoId++;
        }
    }
}