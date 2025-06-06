using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using Cantina2._0.Models;
using static Cantina2._0.BancoDePedidos;

namespace Cantina2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            boxRemove.Minimum = 1;
            boxQuantity.Minimum = 1;

            ListDisp.Items.Add(new Produto("Pão de Queijo", 3.50,true));
            ListDisp.Items.Add(new Produto("Coxinha", 5.00, true));
            ListDisp.Items.Add(new Produto("Pastel de Carne", 6.00, false));
            ListDisp.Items.Add(new Produto("Pastel de Queijo", 5.50, false));
            ListDisp.Items.Add(new Produto("Refrigerante Lata", 4.50, true));
            ListDisp.Items.Add(new Produto("Hamburguer Simples", 8.00, false));
            ListDisp.Items.Add(new Produto("Hambúrguer com Queijo", 9.00, false));
            ListDisp.Items.Add(new Produto("X-Tudo", 12.00, false));
            ListDisp.Items.Add(new Produto("Água Mineral(500ml)", 4.00, true));

        }

        private double total = 0;

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (ListDisp.SelectedItem == null)
            {

                MessageBox.Show("Selecione um produto.", "Erro");
                return;
            }
            int QuantidadeSelecionada = (int)boxQuantity.Value;

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
                    int quantidadeAtual = int.Parse(item.Substring(item.LastIndexOf('|') + 1).Trim());
                    quantidadeAtual += QuantidadeSelecionada;
                    Carrinho.Items[i] = $"{produtoSelecionado} | {quantidadeAtual}";
                    itemExistente = true;
                    break;
                }
            }
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


                int posPreco = parteProduto.LastIndexOf(" - R$");
                string nomeProduto = posPreco > 0 ? parteProduto.Substring(0, posPreco).Trim() : parteProduto;


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
                    Carrinho.Items[index] = $"{parteProduto} |  {quantidadeAtual}";
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
                MessageBox.Show("O carrinho está vazio. Adicione itens antes de finalizar o pedido.", "Erro");
                return;
            }
            if (total == 0)
            {
                MessageBox.Show("Insira itens no carrinho");
                return;
            }


            int metodoPagamento = comboBox1.SelectedIndex;
            double valorPago = 0;
            double troco = 0;
            bool pagamentoOk = false;
            List<string> resumo = new();
            foreach (ItemPedido itemExt in Carrinho.SelectedItems) 
            {
                resumo.Add(itemExt.NomeProduto);
               
            }
            //Lista para a entrega de cozinha
            
            switch (metodoPagamento)
            {
                case 0: // Dinheiro

                    MessageBox.Show(
                    $"Cliente: {nome}\n\n" +
                    $"Total a pagar: R${total:F2}\n\n" +
                    $"Extrato:{resumo}" +
                    "COMANDA");
                    MessageBox.Show("Qual quantidade o cliente irá pagar?", "Pagamento");

                    while (valorPago < total)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor pago:", "Pagamento", "0")
                            ;
                        if (double.TryParse(input.Replace(',', '.'), out valorPago))
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
                                pagamentoOk = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido. Tente novamente.");
                        }
                    }
                    break;
                    
                case 1: // Cartão de crédito
                case 2: // Cartão  dedébito
                case 3: // PIX
                case 4: // Vale Refeição
                case 5: // Vale Alimentação
                    MessageBox.Show(
                        $"Cliente: {nome}\n\n" +
                        $"Itens:{Carrinho.SelectedItems.ToString}" +
                        $"Total a pagar: R${total:F2}\n\n" +
                        "COMANDA");
                    MessageBox.Show("Pagamento realizado com sucesso!");
                    pagamentoOk = true;
                    break;
                default:
                    MessageBox.Show("Selecione um método de pagamento válido.", "Erro");
                    return;
            }

            if (!pagamentoOk)
                return;
            List<Pedido> pedidosBalcao = new List<Pedido>();
            Pedido pedido2 = new Pedido()
            {
                NomeCliente = nome,
                Data = DateTime.Now,
                Status = StatusPedido.A_Fazer,
                ItensBalcao = new List<ItemPedido>(),
                CheckViagem = checkViagem
            };
            Pedido pedido = new Pedido()
            {
                NomeCliente = nome,
                Data = DateTime.Now,
                Status = StatusPedido.A_Fazer,
                ItensCozinha = new List<ItemPedido>(),
                CheckViagem = checkViagem
            };
          
            
            foreach (var itemObj in Carrinho.Items)
            {
                string item = itemObj.ToString();
                var partes = item.Split('|');
                if (partes.Length != 2) continue;

                var prodPrecoSplit = partes[0].Trim().Split(new[] { " - R$ " }, StringSplitOptions.None);
                if (prodPrecoSplit.Length != 2) continue;

                string nomeProduto = prodPrecoSplit[0].Trim();
                double preco = double.Parse(prodPrecoSplit[1].Trim());
                int quantidade = int.Parse(partes[1].Trim());

                Produto produtoOriginal = null;
                foreach (Produto p in ListDisp.Items)
                {
                    if (p.Nome == nomeProduto)
                    {
                        produtoOriginal = p;
                        break;
                    }
                }
                pedido2.ItensBalcao.Add(new ItemPedido
                {
                    NomeProduto = nomeProduto,
                    Preco = preco,
                    Quantidade = quantidade,
                });
                BancoDePedidos.BancoPedidos.AdicionarPedidoBalcao(pedido2);
                if (produtoOriginal == null) continue;

                if (!produtoOriginal.IsChapa)
                {
                    pedido.ItensCozinha.Add(new ItemPedido
                    {
                        NomeProduto = nomeProduto,
                        Preco = preco,
                        Quantidade = quantidade
                    });
                    BancoPedidos.AdicionarPedidoBalcao(pedido);
                   
                }
            }

            BancoPedidos.AdicionarPedido(pedido);
           
            Carrinho.Items.Clear();
            textBox1.Clear();
            total = 0;

            MessageBox.Show($"Pedido do cliente {nome} registrado com sucesso!");

            TelaBalcao telaBalcao = new TelaBalcao();
            telaBalcao.Show();
            Tela_da_cozinha tela_Da_Cozinha = new Tela_da_cozinha();
            tela_Da_Cozinha.Show();
        }

        private void ListDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
