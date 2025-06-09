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

namespace Cantina2._0
{
    public partial class Tela_da_cozinha : Form
    {
        private Dictionary<string, StatusPedido> statusPedidos2;


        public Tela_da_cozinha()
        {
            InitializeComponent();
            statusPedidos2 = new Dictionary<string, StatusPedido>();
           

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
                Status = statusPedidos2.TryGetValue(p.NomeCliente, out StatusPedido value)
                        ? value.ToString()
                        : StatusPedido.A_Fazer.ToString(),
                checkViagem = p.CheckViagem.Checked,
                Total = p.ItensBalcao.Sum(i => i.Preco * i.Quantidade).ToString("F2")
            }).ToList();

            
            dataGridView1.DataSource = pedidosFormatados;

            // Ajuste os headers das colunas
            dataGridView1.Columns[0].HeaderText = "Nome Cliente";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Itens";
            dataGridView1.Columns[3].HeaderText = "Status";
            dataGridView1.Columns[4].HeaderText = "É Viagem?";
            dataGridView1.Columns[5].HeaderText = "Total (R$)";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir Narrow", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Agrandir", 10, FontStyle.Regular);
        }

        private StatusPedido ProximoStatus(StatusPedido atual)
        {
            switch (atual)
            {
                case StatusPedido.Entregue:
                default:
                    return StatusPedido.A_Fazer;
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void Tela_da_cozinha_Load(object sender, EventArgs e)
        {
          
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                listBox1.Items.Clear();
                var nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["NomeCliente"].Value.ToString();
                var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                if (pedido != null)
                {
                    foreach (var item in pedido.ItensBalcao)
                    {
                        listBox1.Items.Add($"{item.NomeProduto} - Quantidade: {item.Quantidade} - Preço: R$ {item.Preco:F2}");
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells["NomeCliente"].Value.ToString();

                if (statusPedidos2.TryGetValue(nomeCliente, out StatusPedido value))
                {
                    statusPedidos2[nomeCliente] = ProximoStatus(value);
                }
                else
                {
                    statusPedidos2[nomeCliente] = StatusPedido.Em_Preparo;
                }

                CarregarPedidos();
            }
            else
            {
                MessageBox.Show("Selecione um pedido para alterar o status.");
            }
        }
    }
}

