using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler___TEventArgs
{
    class Pedido
    {
        public event EventHandler<PedidoEventArgs>? OnCriarPedido;
        public void CriarPedido(string email, string telefone)
        {

            Console.WriteLine("\nPedido criado!!!");
            if (OnCriarPedido != null)
            {
                OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone});
            }
        }
    }
}
