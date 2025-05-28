using System;
using System.Collections.Generic;
using System.Linq;
using Cantina2._0.Models;

namespace Cantina2._0
{
    internal class Pedido
    {
        public string NomeCliebte { get; set; }
            public string NomeProduto { get; set; }
            public DateTime Data { get; set; }
            public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
            public StatusPedido Status { get; set; } = StatusPedido.A_Fazer;

            public double Total => Itens.Sum(i => i.Preco * i.Quantidade);

        public override string ToString()
            {
                return $"{Nome} - {Status} - R$ {Total:F2}";
            }
        }
    }
