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
    public partial class TelaChamada : Form
    {
        public TelaChamada()
        {
            InitializeComponent();
            CarregarPedidos();
            pictureBox1.TabStop = false;
        }

        private void TelaChamada_Load(object sender, EventArgs e)
        {

        }
        private void CarregarPedidos()
        {
            var pedidos = BancoDePedidos.BancoPedidos.GetPedidosProBalcao();

            var pedidosFormatados = pedidos.Select(p => new
            {
                NomeCliente = p.NomeCliente,
                Data = p.Data.ToString("dd/MM/yyyy HH:mm"),
                Status = p.Status.ToString(),

            }).ToList();


            dataGridView1.DataSource = pedidosFormatados;





            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir Narrow", 12, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font = new Font("Agrandir", 11, FontStyle.Regular);
            dataGridView1.Columns[0].HeaderText = "CLIENTE";
            dataGridView1.Columns[1].HeaderText = "DATA/HORA";
            dataGridView1.Columns[3].HeaderText = "STATUS";
            dataGridView1.Columns[5].HeaderText = "TOTAL (R$)";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;

        }
        private void AtualizarTela_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
            Tela_Chamada chamada = new Tela_Chamada   ();
            chamada.Show();
            this.Hide();
        }


    }
}
