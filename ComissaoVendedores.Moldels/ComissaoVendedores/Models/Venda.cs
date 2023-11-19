namespace ComissaoVendedores.Models;

public class Venda
{
    public int IdVendedor { get; set; }
    public string NomeVendedor { get; set; }
    public List<Produtos> ProdutosVendidos { get; set; }
    public Dictionary<int, int> QuantidadePorProduto { get; set; }
    public decimal ValorTotal { get; set; }
}