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
{

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
            Status = p.Status.ToString(),
        }).ToList();


        dgv.DataSource = pedidosFormatados; }



private void Tela_de_chamada_Load(object sender, EventArgs e)
{

}

private void btnChamar_Click(object sender, EventArgs e)
{
}





private void PersonalizarTela()
{
    // Fundo da tela
    this.BackColor = ColorTranslator.FromHtml("#11190C");
    this.Size = new Size(800, 600);

    // Logo (PictureBox)
    PictureBox logo = new PictureBox();
    logo.Image = Image.FromFile("logo_bolt_yellow.png"); // Use a logo Lightning Yellow para fundo escuro
    logo.SizeMode = PictureBoxSizeMode.Zoom;
    logo.Location = new Point(20, 20);
    logo.Size = new Size(60, 60);
    this.Controls.Add(logo);

    // Título
    Label lblTitulo = new Label();
    lblTitulo.Text = "Fila de Chamadas";
    lblTitulo.Font = new Font("Arial Narrow", 28, FontStyle.Bold); // Use Agrandir Narrow se disponível
    lblTitulo.ForeColor = ColorTranslator.FromHtml("#E1FF00");
    lblTitulo.Location = new Point(100, 30);
    lblTitulo.AutoSize = true;
    this.Controls.Add(lblTitulo);

    // DataGridView
    DataGridView dgv = new DataGridView();
    dgv.Location = new Point(20, 100);
    dgv.Size = new Size(750, 350);
    dgv.BackgroundColor = ColorTranslator.FromHtml("#F3F1EE");
    dgv.EnableHeadersVisualStyles = false;

    // Cabeçalho
    dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#11190C");
    dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#E1FF00");
    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

    // Linhas alternadas
    dgv.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F1EE");
    dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CAC4B7");
    dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#11190C");
    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);

    // Exemplo de colunas
    dgv.Columns.Add("colNome", "Nome");
    dgv.Columns.Add("colHorario", "Horário");
    dgv.Columns.Add("colStatus", "Status");

    this.Controls.Add(dgv);

    // Botão
}

}}