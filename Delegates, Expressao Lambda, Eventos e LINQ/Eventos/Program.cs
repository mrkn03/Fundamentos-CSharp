
using Eventos;

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido();


delegate void PedidoEventHandler();