using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace APICatalogo1.Models;

[Table("Categorias")] // nome da tabela no banco de dados
public class Categoria
{
    public Categoria() // inicializando coleção
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public String? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public String? ImagemUrl { get; set; }
    
    public ICollection<Produto> Produtos { get; set; } // 1 para muitos
}


