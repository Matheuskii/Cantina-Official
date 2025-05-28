using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cantina2._0.Models;

namespace Cantina2._0
{
    internal static class BancoDePedidos
    {

        internal static class BancoPedidos
        {
            private static List<Pedido> pedidos = new List<Pedido>();

            public static void AdicionarPedido(Pedido pedido)
            {
                pedidos.Add(pedido);
            }

            public static List<Pedido> GetPedidos()
            {
                return pedidos;
            }
        }

    }

}