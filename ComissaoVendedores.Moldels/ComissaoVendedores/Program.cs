using ComissaoVendedores.Models;


int _Id = 0;

List<Vendedores> vendedoresList = new()
{
    new Vendedores {IdVendedor = ++_Id,Nome = "Paulo"},
    new Vendedores { IdVendedor = ++_Id, Nome = "Ana"}
};

int _Cod = 0;

List<Produtos> produtosList = new()
{
    new Produtos{CodProduto = ++_Cod, PrecoProduto = 5, NomeProduto = "Mouse"},
    new Produtos{CodProduto = ++_Cod, PrecoProduto = 8, NomeProduto = "Fone"},
    new Produtos{CodProduto = ++_Cod, PrecoProduto = 3, NomeProduto = "teclado"},
};


if ( produtosList.Count > 1)
{
    List<Venda> vendaList = new()
    {
        new Venda
        {
            IdVendedor = vendedoresList[1].IdVendedor,
            NomeVendedor = vendedoresList[1].Nome,
            ProdutosVendidos = new List<Produtos> { produtosList[0], produtosList[1] },
            QuantidadePorProduto = new Dictionary<int, int>
            {
                { produtosList[0].CodProduto, 3 },
                { produtosList[1].CodProduto, 1 }
            },
            ValorTotal = (3 * produtosList[0].PrecoProduto) + (1 * produtosList[1].PrecoProduto)
        }
    };

    foreach (var vendaFeita in vendaList)
    {
        Console.WriteLine($"Vendedor: {vendaFeita.NomeVendedor}");
        Console.WriteLine("Vendas realizadas: ");
        foreach (Produtos produtosVendidos in vendaFeita.ProdutosVendidos)
        {
            int quantidade = vendaFeita.QuantidadePorProduto[produtosVendidos.CodProduto];
            Console.WriteLine($"{quantidade} - {produtosVendidos.NomeProduto} - {produtosVendidos.PrecoProduto * quantidade:C2}");
        }

        decimal comissao = (decimal)0.05;
        Console.WriteLine($"Valor total foi de {vendaFeita.ValorTotal:C}");
        Console.WriteLine($"E a Comissão será de  {vendaFeita.ValorTotal * comissao:C}");


    }
}
else
{
    Console.WriteLine("Lista de vendedores ou lista de produtos está vazia ou não contém elementos suficientes.");
}





