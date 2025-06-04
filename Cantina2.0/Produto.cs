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