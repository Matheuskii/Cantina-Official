using System.ComponentModel;
using Cantina2._0.Models;
namespace Cantina2._0
{
    internal static class BancoDePedidos
    {

        internal static class BancoPedidos
        {
            public static BindingList<Pedido> pedidos = new BindingList<Pedido>();
            

            public static void AdicionarPedido(Pedido pedido)
            {
                pedidos.Add(pedido);
            }

            public static BindingList<Pedido> GetPedidos()
            {
                return pedidos;
            }
        }

    }

}