
using Event_Handler;

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido();
