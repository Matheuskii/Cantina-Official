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
                case StatusPedido.A_Fazer: return StatusPedido.Em_Preparo;
                case StatusPedido.Em_Preparo: return StatusPedido.Pronto;
                case StatusPedido.Pronto: return StatusPedido.Entregue;
                case StatusPedido.Entregue: return StatusPedido.A_Fazer;
                default: return StatusPedido.A_Fazer;
            }
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
                else
                {
                    listBox1.Items.Clear();
                }

            }
            else
            {
                listBox1.Items.Clear();
            }
        }
        

        private void btnAtualizarStatus(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var dataString = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

               
                var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                if (pedido != null)
                {
                    pedido.Status = ProximoStatus(pedido.Status);
                    CarregarPedidos();
                    dataGridView1.ClearSelection();
                    if (pedido.Status == StatusPedido.Entregue)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja retirar o pedido da lista?", "Confirmação", buttons);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        BancoDePedidos.BancoPedidos.pedidosProBalcao.Remove(pedido);
                        MessageBox.Show("Pedido removido com sucesso!");
                        listBox1.Items.Clear();
                        CarregarPedidos();
                       
                    }
                    else
                    {
                        MessageBox.Show($"Status atualizado para:{pedido.Status}");
                    }
                }
                else
                {
                    MessageBox.Show("Pedido não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para atualizar o status.");
            }
        }
        private void btnRetirarPedido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var dataString = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                if (pedido != null)
                {
                    DialogResult result = MessageBox.Show($"Deseja retirar o pedido de {pedido.NomeCliente}?",
                        "Retirar Pedido", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show($"Pedido de {pedido.NomeCliente} retirado com sucesso!");
              
                        BancoDePedidos.BancoPedidos.pedidosProBalcao.Remove(pedido);
                        CarregarPedidos();
                        listBox1.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Retirada cancelada.");
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Pedido não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para retirar.");
            }
        }

        private void Tela_do_balcao_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


