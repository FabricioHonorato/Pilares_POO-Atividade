namespace PilaresPOO_atividade
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(string marca, string modelo, int quantidadePortas) : base(marca, modelo)
        {
            QuantidadePortas = quantidadePortas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Quantidade de portas do veículo: {QuantidadePortas}");
        }
    }
}