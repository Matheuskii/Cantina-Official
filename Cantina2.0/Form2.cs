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

    public partial class Form2 : Form
    {
         

        private List<Produto> produtinhos = PersistenteProdutoa.Produtos;
        public Form2()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
           
            listView1.Columns.Add(Name);
            listView1.Columns.Add("Pedido", Name);


        }






        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task ListNotPrepared_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}