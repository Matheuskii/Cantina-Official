using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Cantina2._0
{
    internal class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"{Nome} - R$ {Preco:F2}";
    }
}

internal class Pedido
{
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public int Quantidade { get; set; }
    public int Total;
    public override string ToString()
    {
        return $"{Nome} - {Quantidade} itens - Total: R$ {Total:F2}";
    }
}
}

