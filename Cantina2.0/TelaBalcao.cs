using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Nome = p.NomeProduto,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Itens = string.Join(", ", p.Itens.Select(i => $"{i.NomeProduto} ({i.Quantidade})")),
                Status = p.Status.ToString(),
                Total = p.Total.ToString("F2")
            }).ToList();

            dataGridView1.DataSource = pedidosFormatados;

            // Ajusta os nomes das colunas (opcional)
            dataGridView1.Columns[0].HeaderText = "Cliente";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Itens";
            dataGridView1.Columns[3].HeaderText = "Status";
            dataGridView1.Columns[4].HeaderText = "Total (R$)";
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
    }
}