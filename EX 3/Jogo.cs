namespace PilaresPOO_atividade
{
    public class Jogo
    {
        public string Nome { get; set; }
        protected string Plataforma { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do Jogo: {Nome}");
            Console.WriteLine($"Plataforma: {Plataforma}"); 
        }
    }
}