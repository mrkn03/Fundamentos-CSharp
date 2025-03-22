using LINQ___Consultas_III;

var listaProdutos = Produto.GetProdutos();

var produtosPorCategoria = listaProdutos
                            .GroupBy(p => p.Categoria)
                            .OrderBy(c => c.Key)
                            .Select(g => new
                            {
                                Categoria = g.Key,
                                Produtos = g.OrderBy(p => p.Nome).Select(p => new {Nome = p.Nome, Preco = p.Preco, Estoque = p.Estoque})
                            });

foreach(var grupo in produtosPorCategoria)
{
    Console.WriteLine(grupo.Categoria);

    foreach(var produto in grupo.Produtos)
    {
        Console.WriteLine($"\t{produto.Nome} \t {produto.Preco:C2}  \t{produto.Estoque}");
    }
}