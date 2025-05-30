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

namespace Cantina2._0
{

    public partial class TelaBalcao : Form
    {




        public TelaBalcao()
        {
            InitializeComponent();

            CarregarPedidos();

        }
        private void CarregarPedidos()
        {
            var pedidosFormatados = BancoDePedidos.BancoPedidos.GetPedidos().Select(p => new
            {
                NomeCliente = p.NomeCliente,
                //NomeProduto = p.NomeProduto,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Itens = string.Join(", ", p.Itens.Select(i => $"{i.NomeProduto} ({i.Quantidade})")),
                Status = p.Status.ToString(),
                checkViagem = p.CheckViagem.Checked,
                Total = p.Total.ToString("F2")
            }).ToList();

            dataGridView1.DataSource = pedidosFormatados;

            // Ajusta os nomes das colunas (opcional)
            dataGridView1.Columns[0].HeaderText = "NomeCliente";
            //dataGridView1.Columns[1].HeaderText = "NomeProduto";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Itens";
            dataGridView1.Columns[3].HeaderText = "Status";
            dataGridView1.Columns[4].HeaderText = "É viagem?";
            dataGridView1.Columns[5].HeaderText = "Total (R$)";
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
            StatusPedido status1 = StatusPedido.A_Fazer;
            StatusPedido status2 = StatusPedido.Em_Preparo;
            StatusPedido status3 = StatusPedido.Entregue;
            if (button1 != null)
            {
                StatusPedido status = StatusPedido.A_Fazer;
            }



        }
    }
}