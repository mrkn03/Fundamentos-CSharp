using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler___TEventArgs
{
    class SMS
    {
        public static void Send(object? sender, PedidoEventArgs e)
        {
            Console.WriteLine($"\nEnviando um SMS para: {e.Telefone}");
        }
    }
}
