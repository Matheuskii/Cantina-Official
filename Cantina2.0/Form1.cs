using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Cantina2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Definindo o valor mínimo para os NumericUpDowns
            boxRemove.Minimum = 1;
            boxQuantity.Minimum = 1;
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
            // Classe para representar um produto
            public string Nome { get; set; }
            public double Preco { get; set; }
            public Produto(string nome, double preco)
            {
                // Construtor da classe Produto
                Nome = nome;
                Preco = preco;
            }
            public override string ToString()
            {
                return $"{Nome} - R$ {Preco:F2}";
            }
        }

        private double total = 0; // Campo para armazenar o total da compra

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Verifica se algum produto foi selecionado
            if (ItemSelected.SelectedItem == null)
            {
                // Se não houver produto selecionado, exibe uma mensagem de erro
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

            // Atualiza o total da compra
            total += produtoSelecionado.Preco * QuantidadeSelecionada;


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

            if (quantidadeRemover <= 0)
            {
                MessageBox.Show("Selecione a quantidade do produto que deseja remover.", "Erro");
                return;
            }

            
            var itensParaRemover = new List<int>();
            foreach (int index in Carrinho.SelectedIndices)
            {
                string item = Carrinho.Items[index].ToString();
                
                int posBarra = item.LastIndexOf('|');
                if (posBarra == -1) continue;

                string parteQuantidade = item.Substring(posBarra + 1).Trim();
                if (!int.TryParse(parteQuantidade, out int quantidadeAtual))
                    continue;

                if (quantidadeAtual > quantidadeRemover)
                {
                    // Atualiza a quantidade
                    string parteProduto = item.Substring(0, posBarra).Trim();
                    int novaQuantidade = quantidadeAtual - quantidadeRemover;
                    Carrinho.Items[index] = $"{parteProduto} | {novaQuantidade}";
                    total -= quantidadeRemover * ((Produto)ItemSelected.SelectedItem).Preco;
                }
                else
                {
                    // Marca para remover o item inteiro
                    itensParaRemover.Add(index);
                }
            }

            // Remove os itens marcados (de trás para frente para não bagunçar os índices)
            for (int i = itensParaRemover.Count - 1; i >= 0; i--)
            {
                Carrinho.Items.RemoveAt(itensParaRemover[i]);
                
            }

          
            boxQuantity.Value = 1;
        }

        private void Carrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja finalizar a compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // Aqui você pode adicionar a lógica para finalizar a compra
                MessageBox.Show($"Total da compra: R$ {total:F2}", "Compra Finalizada");
                Carrinho.Items.Clear();
                total = 0;
            }

        } 
    }
}
