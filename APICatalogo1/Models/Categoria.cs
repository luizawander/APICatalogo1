using System.Collections.ObjectModel;

namespace APICatalogo1.Models;

public class Categoria
{
    public Categoria() // inicializando coleção
    {
        Produtos = new Collection<Produto>();
    }
    public int CategoriaId { get; set; }
    public String? Nome { get; set; }
    public String? ImagemUrl { get; set; }
    
    public ICollection<Produto> Produtos { get; set; } // 1 para muitos
}


