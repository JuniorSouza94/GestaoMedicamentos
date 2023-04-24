namespace GestaoMedicamentos.ConsoleApp
{
    public class Aquisicao
    {
        private static int _proximoId = 1;
        public int AquisicaoID { get; private set; }
        public Fornecedor Fornecedor { get; set; }
        public Medicamento Medicamento { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int QuantidadeMedicamento { get; set; }
        public Aquisicao()
        {
            AquisicaoID = _proximoId;
            _proximoId++;
        }
    }
}