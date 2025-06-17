using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina2._0.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina2._0
{

    public partial class TelaCozinha : Form
    {


        public TelaCozinha()
        {

            InitializeComponent();
  

            pictureBox1.TabStop = false;
            
            CarregarPedidos();

        }
        private void CarregarPedidos()
        {
            var pedidos = BancoDePedidos.BancoPedidos.GetPedidos();

            var pedidosFormatados = pedidos.Select(p => new
            {
                NomeCliente = p.NomeCliente,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Itens = string.Join(", ", p.ItensCozinha.Select(i => $"{i.NomeProduto} ({i.Quantidade})")),
                Status = p.Status.ToString(),
                checkViagem = p.CheckViagem.Checked,
            }).ToList();

            dataGridView1.DataSource = pedidosFormatados;

            // Ajuste os headers das colunas
            dataGridView1.Columns[0].HeaderText = "NOME DO CLIENTE";
            dataGridView1.Columns[1].HeaderText = "DATA/HORA";
            dataGridView1.Columns[2].HeaderText = "ITENS";
            dataGridView1.Columns[3].HeaderText = "STATUS";
            dataGridView1.Columns[4].HeaderText = "VIAGEM";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;


            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir Narrow", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Agrandir", 10, FontStyle.Regular);
        }
        private StatusPedido ProximoStatus(StatusPedido atual)
        {
            switch (atual)
            {
                case StatusPedido.A_Fazer:
                    return StatusPedido.Em_Preparo;
                case StatusPedido.Em_Preparo:
                    return StatusPedido.Entregue;
                case StatusPedido.Entregue:
                default:
                    return StatusPedido.A_Fazer;
            }
        }
            private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var data = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                var pedido = BancoDePedidos.BancoPedidos.GetPedidos()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente && p.Data == data);

                if (pedido != null)
                {
                    BancoDePedidos.BancoPedidos.pedidosPraCozinha.Remove(pedido);
                    BancoDePedidos.BancoPedidos.AdicionarPedidoBalcao(pedido);

                    CarregarPedidos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para retirar.");
                dataGridView1.ClearSelection();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {


        }
        private void MostrarComandaListBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                listBox1.Items.Clear();

                var nomeCliente = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                var pedido = BancoDePedidos.BancoPedidos.GetPedidos()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                if (pedido != null)
                {
                    foreach (var item in pedido.ItensCozinha)
                    {
                        listBox1.Items.Add($"{item.NomeProduto} - x{item.Quantidade} - R$ {item.Preco:F2}");
                    }

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }

            }
        }

       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Botão para avançar o status do pedido selecionado no balcão.
        private void btnStatus_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count >= 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                var data = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

                var pedido = BancoDePedidos.BancoPedidos.GetPedidos()
                .FirstOrDefault(p => p.NomeCliente == nomeCliente || p.Data == data);

                if (pedido != null)
                {
                    pedido.Status = ProximoStatus(pedido.Status);
                    CarregarPedidos();
                    dataGridView1.ClearSelection();
                    if (pedido.Status == StatusPedido.Entregue)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja entregar o pedido para o Balcão?", "Confirmação", buttons);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        BancoDePedidos.BancoPedidos.pedidosPraCozinha.Remove(pedido);
                        BancoDePedidos.BancoPedidos.AdicionarPedidoBalcao(pedido);
                        MessageBox.Show("Pedido entregue com sucesso!");
                        CarregarPedidos();
                    }
                    else
                    {
                        MessageBox.Show($"Status do pedido alterado para: {pedido.Status}");
                        CarregarPedidos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para alterar o status.");
                dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {


        }
    }

}