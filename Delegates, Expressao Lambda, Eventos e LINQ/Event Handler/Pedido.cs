namespace Event_Handler
{
    class Pedido
    {
        public event EventHandler? OnCriarPedido;
        public void CriarPedido()
        {

            Console.WriteLine("\nPedido criado!!!");
            if (OnCriarPedido != null)
            {
                OnCriarPedido(this, EventArgs.Empty);
            }
        }
    }
}
