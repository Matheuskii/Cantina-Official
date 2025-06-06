namespace Cantina2._0.Models
{
    internal class Pedido
    {
        public string NomeCliente { get; set; }
            public string NomeProduto { get; set; }
            public DateTime Data { get; set; }
            public List<ItemPedido> ItensCozinha { get; set; } = new List<ItemPedido>();
        public List<ItemPedido> ItensBalcao { get; set; } = new List<ItemPedido>();
        public StatusPedido Status { get; set; } = StatusPedido.A_Fazer;

            public double Total => ItensCozinha.Sum(i => i.Preco * i.Quantidade);
            public CheckBox CheckViagem { get; set; }
       


        public override string ToString()
            {
                return $"{NomeCliente} - {Status} - R$ {Total:F2}";
            }
        }
    }
