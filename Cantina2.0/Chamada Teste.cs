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


namespace Cantina2._0;
{}

    public partial class Tela_de_chamada : Form
{



    public Tela_de_chamada()
    {
        InitializeComponent();
    }
    private void CarregarPedidos()
    {
        var pedidosChamada = BancoDePedidos.BancoPedidos.GetPedidosProBalcao();

        var pedidosFormatados = pedidosChamada.Select(p => new
        {
            NomeCliente = p.NomeCliente,
            Data = p.Data.ToString(),
            Status = p.Status.ToString(),
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
        datagridView1.Columns[1].Visible = false;
        datagridView1.Columns[2].Visible = false;
        datagridView1.Columns[4].Visible = false;
        datagridView1.Columns[5].Visible = false;
        datagridView1.AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill;
        

    private void Tela_de_chamada_Load(object sender, EventArgs e)
    {

    }

    private void btnChamar_Click(object sender, EventArgs e)
    {
    }
    
        
    
}