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
    public partial class Tela_da_cozinha : Form
    {
        public Tela_da_cozinha()
        {
            InitializeComponent();
            dataGridView1.DataSource = BancoDePedidos.BancoPedidos.GetPedidosProBalcao();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_da_cozinha_Load(object sender, EventArgs e)
        {

        }
    }
}
