﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo1.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Bebidas','bebidas.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Lanches','lanches.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Sobremesas','sobremesas.jpg')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
