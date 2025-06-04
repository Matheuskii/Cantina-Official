namespace Cantina2._0.Models
{
    public class ItemPedido
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

 

        public override string ToString()
        {
            return $"{NomeProduto} - {Quantidade} x R$ {Preco:F2}";
        }
    }
}