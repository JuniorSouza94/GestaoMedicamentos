namespace GestaoMedicamentos.ConsoleApp
{
    public class Requisicao
    {
        private static int _proximoId = 1;
        public int RequisicaoID { get; private set; }
        public Paciente Paciente { get; set; }
        public Medicamento Medicamento { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataRequisicao { get; set; }
        public int Quantidade { get; set; }
        public Requisicao()
        {
            RequisicaoID = _proximoId;
            _proximoId++;
        }

        public Requisicao(Paciente paciente, Medicamento medicamento, Funcionario funcionario, int quantidade)
        {
            Paciente = paciente;
            Medicamento = medicamento;
            Funcionario = funcionario;
            Quantidade = quantidade;
        }
    }

}