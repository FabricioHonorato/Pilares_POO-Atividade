namespace PilaresPOO_atividade
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public Motocicleta(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Cilindradas do veículo: {Cilindradas}");
        }
    }
}