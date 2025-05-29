using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo1.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome, Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Coca-Cola','Regrigerante de Cola 350ml',5.45,'cocacola.jpg',50,now(),1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Produtos");
        }
    }
}
