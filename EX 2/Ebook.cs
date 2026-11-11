namespace PilaresPOO_atividade
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook()
        {
            
        }
        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do Ebook: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Número de páginas: {QuantidadePaginas}");
        }
    }
}