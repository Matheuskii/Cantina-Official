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

    public partial class TelaBalcao : Form
    {

        private Dictionary<string, StatusPedido> statusPedidos = new Dictionary<string, StatusPedido>();


        public TelaBalcao()
        {

            InitializeComponent();

            CarregarPedidos();

        }
        private void CarregarPedidos()
        {
            var pedidos = BancoDePedidos.BancoPedidos.GetPedidos();

            var pedidosFormatados = pedidos.Select(p => new
            {
                NomeCliente = p.NomeCliente,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Itens = string.Join(", ", p.Itens.Select(i => $"{i.NomeProduto} ({i.Quantidade})")),
                Status = statusPedidos.ContainsKey(p.NomeCliente)
                        ? statusPedidos[p.NomeCliente].ToString()
                        : StatusPedido.A_Fazer.ToString(),
                checkViagem = p.CheckViagem.Checked,
                Total = p.Total.ToString("F2")
            }).ToList();

            dataGridView1.DataSource = pedidosFormatados;

            // Ajuste os headers das colunas
            dataGridView1.Columns[0].HeaderText = "Nome Cliente";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Itens";
            dataGridView1.Columns[3].HeaderText = "Status";
            dataGridView1.Columns[4].HeaderText = "É Viagem?";
            dataGridView1.Columns[5].HeaderText = "Total (R$)";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir ", 12, FontStyle.Bold);
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







        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nomeCliente = dataGridView1.SelectedRows[0].Cells["NomeCliente"].Value.ToString();

                if (statusPedidos.ContainsKey(nomeCliente))
                {
                    statusPedidos[nomeCliente] = ProximoStatus(statusPedidos[nomeCliente]);
                }
                else
                {
                    statusPedidos[nomeCliente] = StatusPedido.Em_Preparo;
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