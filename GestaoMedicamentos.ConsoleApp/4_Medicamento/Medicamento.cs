namespace GestaoMedicamentos.ConsoleApp
{
    public class Medicamento
    {
        private static int _proximoId = 1;
        private int quantidadeMinima = 5;
        public int MedicamentoID { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeRetiradas { get; set; }
        public int QuantidadeMinima
        {
            get { return quantidadeMinima; }
            set
            {
                if (value > 0)
                {
                    quantidadeMinima = value;
                }
                else
                {
                    Console.WriteLine("A quantidade mínima deve ser maior que zero.");
                }
            }
        }
        public Fornecedor Fornecedor { get; set; }
        public Medicamento()
        {
            MedicamentoID = _proximoId;
            _proximoId++;
        }
        public void RetirarMedicamento(int quantidade)
        {
            if (quantidade > QuantidadeDisponivel)
            {
                throw new InvalidOperationException("Não há medicamentos suficientes em estoque para a retirada solicitada.");
            }
            QuantidadeDisponivel -= quantidade;
            QuantidadeRetiradas += quantidade; // atualização da nova propriedade
        }

    }

}