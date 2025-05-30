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
        public bool IsChapa { get; set; }

        public Produto(string nome, double preco, bool isChapa)
        {
            Nome = nome;
            Preco = preco;
            IsChapa = isChapa;
        }

        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}