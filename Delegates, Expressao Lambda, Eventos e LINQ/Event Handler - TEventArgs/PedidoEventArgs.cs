using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler___TEventArgs
{
    class PedidoEventArgs : EventArgs
    {
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}
