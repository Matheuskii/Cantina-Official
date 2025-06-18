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
            
            }
        }
    }




