using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Pedido
    {
        public event PedidoEventHandler? OnCriarPedido;
        public void CriarPedido()
        {

            Console.WriteLine("\nPedido criado!!!");
            if(OnCriarPedido != null)
            {
                OnCriarPedido();
            }
        }
    }
}
