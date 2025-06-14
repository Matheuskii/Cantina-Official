using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina2._0.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina2._0
{
    public partial class Tela_do_balcao : Form
    {


        public Tela_do_balcao()
        {
            InitializeComponent();
            pictureBox1.TabStop = false;

            CarregarPedidos();


        }
        private void CarregarPedidos()
        {
            var pedidos = BancoDePedidos.BancoPedidos.GetPedidosProBalcao();

            var pedidosFormatados = pedidos.Select(p => new
            {
                NomeCliente = p.NomeCliente,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Itens = string.Join(", ", p.ItensBalcao.Select(i => $"{i.NomeProduto} ({i.Quantidade})")),
                Status = p.Status.ToString(),
                checkViagem = p.CheckViagem.Checked,
                Total = p.ItensBalcao.Sum(i => i.Preco * i.Quantidade).ToString("F2")
            }).ToList();


            dataGridView1.DataSource = pedidosFormatados;





            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir Narrow", 12, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font = new Font("Agrandir", 11, FontStyle.Regular);
            dataGridView1.Columns[0].HeaderText = "CLIENTE";
            dataGridView1.Columns[1].HeaderText = "DATA/HORA";
            dataGridView1.Columns[2].HeaderText = "ITENS";
            dataGridView1.Columns[3].HeaderText = "STATUS";
            dataGridView1.Columns[4].HeaderText = "VIAGEM?";
            dataGridView1.Columns[5].HeaderText = "TOTAL (R$)";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }


        private StatusPedido ProximoStatus(StatusPedido atual)
        {
            switch (atual)
            {
                case StatusPedido.A_Fazer: return StatusPedido.Em_Preparo;
                case StatusPedido.Em_Preparo: return StatusPedido.Pronto;
                case StatusPedido.Pronto: return StatusPedido.Entregue;
                default: return StatusPedido.A_Fazer;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Tela_da_cozinha_Load(object sender, EventArgs e)
        {

        }

        private void MostrarComandaListBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                listBox1.Items.Clear();

                var nomeCliente = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                if (pedido != null && pedido.ItensBalcao != null)
                {
                    foreach (var item in pedido.ItensBalcao)
                    {
                        listBox1.Items.Add($"{item.NomeProduto} - x{item.Quantidade} - R$ {item.Preco:F2}");
                    }

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }

            }
        }

        private void UpdateOrderStatus_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para alterar o status.");
                return;
            }

            var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var dataStr = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var data = DateTime.ParseExact(dataStr, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);

            var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                .FirstOrDefault(p => p.NomeCliente == nomeCliente && p.Data == data);

            if (pedido == null)
            {
                MessageBox.Show("Pedido não encontrado.");
                return;
            }

            pedido.Status = ProximoStatus(pedido.Status);

            if (pedido.Status == StatusPedido.Entregue)


                CarregarPedidos();

        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para retirar.");
                return;
            }

            var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var dataStr = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var data = DateTime.ParseExact(dataStr, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);

            var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                .FirstOrDefault(p => p.NomeCliente == nomeCliente && p.Data == data);

            if (pedido != null)
            {
                MessageBox.Show("Pedido não encontrado.");
                return;
            }


            CarregarPedidos();

        }
    }
}


