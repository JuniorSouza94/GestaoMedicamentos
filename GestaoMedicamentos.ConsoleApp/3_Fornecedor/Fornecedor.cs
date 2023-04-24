namespace GestaoMedicamentos.ConsoleApp
{
    public class Fornecedor
    {
        private static int _proximoId = 1;
        public int FornecedorID { get; private set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public List<Medicamento> MedicamentosFornecidos { get; set; }
        public Fornecedor()
        {
            FornecedorID = _proximoId;
            _proximoId++;
        }
    }
}