namespace APICatalogo1.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public String? Nome { get; set; }
    public String? Descricao { get; set; }
    public decimal Preco { get; set; }
    public String? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

}
