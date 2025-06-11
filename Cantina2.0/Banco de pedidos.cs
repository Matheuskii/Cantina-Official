using System.ComponentModel;
using Cantina2._0.Models;
namespace Cantina2._0
{
internal static class BancoDePedidos
{

        internal static class BancoPedidos
        {
            public static BindingList<Pedido> pedidosPraCozinha = new BindingList<Pedido>();
            public static BindingList<Pedido> pedidosProBalcao = new BindingList<Pedido>();


            public static void AdicionarPedido(Pedido pedido)
            {
                pedidosPraCozinha.Add(pedido);

            }
            public static void AdicionarPedidoBalcao(Pedido pedido2)
            {
                pedidosProBalcao.Add(pedido2);

            }

            public static BindingList<Pedido> GetPedidos()
            {
                return pedidosPraCozinha;

            }
            public static BindingList<Pedido> GetPedidosProBalcao()
            {
                return pedidosProBalcao;
            }
            public static void AtualizarStatusNoBalcao()
            {
                // Obter apenas pedidos marcados como Entregue
                var pedidosEntregues = pedidosPraCozinha
                    .Where(p => p.Status == StatusPedido.Entregue)
                    .ToList();

                foreach (var pedido in pedidosEntregues)
                {
                    var pedidoExistente = pedidosProBalcao.FirstOrDefault(p => p.NomeCliente == pedido.NomeCliente);

                    if (pedidoExistente == null)
                    {
                        pedidosProBalcao.Add(pedido);
                    }
                    else
                    {
                      
                        pedidosProBalcao.Remove(pedidoExistente);
                        pedidosProBalcao.Add(pedido);
                    }
                    pedidosPraCozinha.Remove(pedido);
                }
            }
        }
    }

}


