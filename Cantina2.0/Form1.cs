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
            // Verifica se algum produto foi selecionado
           string selectedItem = ItemSelected.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("Selecione um produto.", "Erro");
                return;
            }
            int QuantidadeSelecionada = (int)boxQuantity.Value;

            // Verifica se a quantidade é válida
            if (QuantidadeSelecionada <= 0)
            {
                
                MessageBox.Show("Selecione a quantidade do produto.", "Erro");
                return;
            }

            Produto produtoSelecionado = (Produto)ItemSelected.SelectedItem;

            // Adiciona o produto e a quantidade ao carrinho
            Carrinho.Items.Add($"{produtoSelecionado} | {QuantidadeSelecionada}");
            
        }
        public static class Globais
        {
            public static int QuantidadeSelecionada { get; set; }

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            int quantidadeRemover = (int)boxRemove.Value;

            // Verifica se algum item está selecionado no carrinho
            if (Carrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item do carrinho para remover.", "Erro");
                return;
            }
            
            // Remove todos os itens selecionados
            while (Carrinho.SelectedItems.Count > 0)
            {
                Carrinho.Items.Remove(Carrinho.SelectedItems[0]);
            } //Verifica se a quantidade é válida
            while (quantidadeRemover <= 0)
            {
                MessageBox.Show("Selecione a quantidade do produto que deseja remover.", "Erro");
                
                return;
            }



            // Reseta a quantidade para 1 após remover item(ns)
            boxQuantity.Value = 1;
        }
    }
}
