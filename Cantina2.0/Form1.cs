using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Cantina2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Definindo o valor m�nimo para os NumericUpDowns
            boxRemove.Minimum = 1;
            boxQuantity.Minimum = 1;
            // Adicionando produtos � lista
            ListDisp.Items.Add(new Produto("P�o de Queijo", 3.50));
            ListDisp.Items.Add(new Produto("Coxinha", 5.00));
            ListDisp.Items.Add(new Produto("Pastel de Carne", 6.00));
            ListDisp.Items.Add(new Produto("Pastel de Queijo", 5.50));
            ListDisp.Items.Add(new Produto("Refrigerante Lata", 4.50));
            ListDisp.Items.Add(new Produto("Hamburguer Simples", 8.00));
            ListDisp.Items.Add(new Produto("Hamb�rguer com Queijo", 9.00));
            ListDisp.Items.Add(new Produto("X-Tudo", 12.00));
            ListDisp.Items.Add(new Produto("�gua Mineral(500ml)", 4.00));

        }

        private double total = 0; // Campo para armazenar o total da compra

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Verifica se algum produto foi selecionado
            if (ListDisp.SelectedItem == null)
            {
                //Se n�o houver produto selecionado, exibe uma mensagem de erro
                MessageBox.Show("Selecione um produto.", "Erro");
                return;
            }
            int QuantidadeSelecionada = (int)boxQuantity.Value;

            // Verifica se a quantidade � v�lida
            if (QuantidadeSelecionada <= 0)
            {
                MessageBox.Show("Selecione a quantidade do produto.", "Erro");
                return;
            }

            Produto produtoSelecionado = (Produto)ListDisp.SelectedItem;
            bool itemExistente = false;
            for (int i = 0; i < Carrinho.Items.Count; i++)
            {
                string item = Carrinho.Items[i].ToString();
                int posBarra = item.LastIndexOf('|');
                string nomeProdutoNoCarrinho = posBarra > 0 ? item.Substring(0, posBarra).Trim() : item;
                if (nomeProdutoNoCarrinho.StartsWith(produtoSelecionado.Nome))
                {
                    // Atualiza a quantidade
                    int quantidadeAtual = int.Parse(item.Substring(item.LastIndexOf('|') + 1).Trim());
                    quantidadeAtual += QuantidadeSelecionada;
                    Carrinho.Items[i] = $"{produtoSelecionado} | {quantidadeAtual}";
                    itemExistente = true;
                    break;
                }
            }
            // Se o item n�o existe, adiciona ao carrinho
            if (!itemExistente)
            {
                Carrinho.Items.Add($"{produtoSelecionado} | {QuantidadeSelecionada}");
            }
            total += produtoSelecionado.Preco * QuantidadeSelecionada;
            ListDisp.ClearSelected();
            boxQuantity.Value = 1;
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
            double totalRemovido = 0;

            foreach (int index in Carrinho.SelectedIndices)
            {
                var itemObj = Carrinho.Items[index];
                if (itemObj == null) continue;
                string item = itemObj.ToString();
                if (string.IsNullOrEmpty(item)) continue;

                int aposBarra = item.LastIndexOf('|');
                if (aposBarra == -1) continue;

                string parteProduto = item.Substring(0, aposBarra).Trim();
                string parteQuantidade = item.Substring(aposBarra + 1).Trim();
                if (!int.TryParse(parteQuantidade, out int quantidadeAtual))
                    continue;

                // Extrai o nome do produto (antes do " - R$")
                int posPreco = parteProduto.LastIndexOf(" - R$");
                string nomeProduto = posPreco > 0 ? parteProduto.Substring(0, posPreco).Trim() : parteProduto;

                // Busca o produto na lista de produtos dispon�veis para obter o pre�o
                Produto? produto = null;
                foreach (var prod in ListDisp.Items)
                {
                    if (prod is Produto p && p.Nome == nomeProduto)
                    {
                        produto = p;
                        break;
                    }
                }
                if (produto == null) continue;

                int quantidadeParaRemover = Math.Min(quantidadeRemover, quantidadeAtual);
                totalRemovido += produto.Preco * quantidadeParaRemover;

                if (quantidadeAtual > quantidadeRemover)
                {
                    quantidadeAtual -= quantidadeRemover;
                    Carrinho.Items[index] = $"{parteProduto} | {quantidadeAtual}";
                    Carrinho.ClearSelected();
                }
                else
                {
                    itensParaRemover.Add(index);
                    Carrinho.ClearSelected();
                }
            }

            total -= totalRemovido;
            if (total < 0) total = 0;

            for (int i = itensParaRemover.Count - 1; i >= 0; i--)
            {
                Carrinho.Items.RemoveAt(itensParaRemover[i]);
            }


            boxRemove.Value = 1;
        }

        private void Carrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            
            

            string nome = textBox1.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira o nome do cliente.", "Erro");
                return;
            }
            if (Carrinho.Items.Count == 0)
            {
                MessageBox.Show("O carrinho est� vazio. Adicione itens antes de finalizar o pedido.", "Erro");
                return;
            }

            if (total == 0)
            {
                MessageBox.Show("Insira itens no carrinho");
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show(
     $"Cliente: {nome}\n\n" +
     $"Total a pagar: R${total:F2}\n\n" +
     "COMANDA");

                    MessageBox.Show("Qual quantidade o cliente ir� pagar?", "Pagamento");
                    double valorPago = 0;
                    double troco = 0;
                    while (valorPago < total)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor pago:", "Pagamento", "0");
                        if (double.TryParse(input, out valorPago))
                        {
                            if (valorPago < total)
                            {
                                MessageBox.Show($"Valor insuficiente. Faltam R$ {total - valorPago:F2}.");
                            }
                            else
                            {
                                troco = valorPago - total;
                                MessageBox.Show($"Troco: R$ {troco:F2}");
                                MessageBox.Show("Pagamento realizado com sucesso!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor inv�lido. Tente novamente.");
                        }
                    }
                    
                    break;
                case 1:
                    MessageBox.Show(
     $"Cliente: {nome}\n\n" +
     $"Total a pagar: R${total:F2}\n\n" +
     "COMANDA");
                    
                    break;
                case 2:
                    MessageBox.Show(
     $"Cliente: {nome}\n\n" +
     $"Total a pagar: R${total:F2}\n\n" +
     "COMANDA");
                    
                    break;
                case 3:
                    MessageBox.Show(
     $"Cliente: {nome}\n\n" +
     $"Total a pagar: R${total:F2}\n\n" +
     "COMANDA");
                    
                    break;
                case 4:
                    MessageBox.Show(
     $"Cliente: {nome}\n\n" +
     $"Total a pagar: R${total:F2}\n\n" +
     "COMANDA");
                    
                    break;
                case 5:
                    MessageBox.Show(
      $"Cliente: {nome}\n\n" +
      $"Total a pagar: R${total:F2}\n\n" +
      "COMANDA");
                    
                    break;
                default:
                    MessageBox.Show("Selecione uma forma de pagamento.", "Erro");
                    break;
            }
            // Adiciona os itens do carrinho ao pedido atual
            foreach (Produto item in Carrinho.Items)
            {
                PersistenteProdutoa.Produtos.Add(item);
            }
            Form2 form2 = new Form2();
            form2.Show();
            Carrinho.Items.Clear();
            textBox1.Clear();
            total = 0;
            



        }

        private void ListDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
