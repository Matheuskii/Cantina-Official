namespace Cantina2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Adicionando produtos à lista
            ItemSelected.Items.Add(new Produto("Pão de Queijo", 3.50));
            ItemSelected.Items.Add(new Produto("Coxinha", 5.00));
            ItemSelected.Items.Add(new Produto("Pastel de Carne", 6.00));
            ItemSelected.Items.Add(new Produto("Pastel de Queijo", 5.50));
            ItemSelected.Items.Add(new Produto("Refrigerante Lata", 4.50));
            ItemSelected.Items.Add(new Produto("Hamburguer Simples", 8.00));
            ItemSelected.Items.Add(new Produto("Hambúrguer com Queijo", 9.00));
            ItemSelected.Items.Add(new Produto("X-Tudo", 12.00));
            ItemSelected.Items.Add(new Produto("Água Mineral(500ml)", 4.00));
        }
        public class Produto
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)ItemSelected.SelectedItem;
            if (ItemSelected.SelectedIndex != -1)
            {
                Carrinho.Items.Add(produtoSelecionado);
                Carrinho.Items.Add("Quantidade: " + numericUpDown1.Value);




            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
