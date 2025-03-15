

using Colecao_Queue___Exemplo;

Queue<Pedido> filaPedidos = new Queue<Pedido>();

//Adicionar pedidos a fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 20.0));

//Exibir pedidos da fila
Console.WriteLine($"Numero de pedidos na fila: {filaPedidos.Count}");

//Processar os pedidos da fila
while(filaPedidos.Count > 0)
{
    //returar o proximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " + $"valor: R${proximoPedido.Valor}");
}

//Adicionar mais pedidos a fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

//Localizar um pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

if (pedidoLocalizado != null)
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila, " +
                           $"valor {pedidoLocalizado.Valor}");
else
    Console.WriteLine($"Pedido {numeroPedido} não encontrado na fila");