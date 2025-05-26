using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina2._0
{
    internal static class PersistenteProdutoa
    {

        public static List<Produto> Produtos { get; set; } = new List<Produto>();
        public static void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public static void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

    }
}
