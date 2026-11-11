namespace PilaresPOO_atividade
{
    public class CursosOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursosOnline()
        {
            
        }
        public CursosOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do curso: {Nome}");
            Console.WriteLine($"Preço do curso: {Preco:C}");
            Console.WriteLine($"Tempo do curso: {CargaHoraria}");
        }
    }
}