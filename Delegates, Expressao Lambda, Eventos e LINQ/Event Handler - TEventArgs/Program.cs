using Event_Handler___TEventArgs;

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido("marcos.fernandes0324@gmail.com", "27997610790");
