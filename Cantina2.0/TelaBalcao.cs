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
    public partial class Tela_da_cozinha : Form
    {
        private Dictionary<string, StatusPedido> statusPedidos2;


        public Tela_da_cozinha()
        {
            InitializeComponent();
            statusPedidos2 = new Dictionary<string, StatusPedido>();
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
                Status = statusPedidos2.TryGetValue(p.NomeCliente, out StatusPedido value)
                        ? value.ToString()
                        : StatusPedido.A_Fazer.ToString(),
                checkViagem = p.CheckViagem.Checked,
                Total = p.ItensBalcao.Sum(i => i.Preco * i.Quantidade).ToString("F2")
            }).ToList();

            
            dataGridView1.DataSource = pedidosFormatados;


            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(240, 240, 240);

         
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Agrandir Narrow", 12, FontStyle.Bold);
          
            // Estilo para células
            dataGridView1.DefaultCellStyle.Font = new Font("Agrandir", 11, FontStyle.Regular);
           

            // Estilo para linhas alternadas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(120, 118, 100);

            // Configuração das colunas
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
        }
        

        private StatusPedido ProximoStatus(StatusPedido atual)
        {
            switch (atual)
            {
                case StatusPedido.A_Fazer: return StatusPedido.Em_Preparo;
                case StatusPedido.Em_Preparo: return StatusPedido.Pronto;
                case StatusPedido.Pronto: return StatusPedido.A_Fazer;
                default: return StatusPedido.A_Fazer;
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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    listBox1.Items.Clear();

                    // PEGA O NOME DO CLIENTE DA LINHA CLICADA (não da selecionada)
                    var nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["NomeCliente"].Value?.ToString();

                    if (!string.IsNullOrEmpty(nomeCliente))
                    {
                        var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                            .FirstOrDefault(p => p.NomeCliente == nomeCliente);

                        if (pedido != null && pedido.ItensBalcao != null)
                        {
                            foreach (var item in pedido.ItensBalcao)
                            {
                                listBox1.Items.Add($"{item.NomeProduto} - x{item.Quantidade} - R$ {item.Preco:F2}");
                            }

                            // SELECIONA A LINHA CLICADA (para o button1 funcionar)
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[e.RowIndex].Selected = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar itens: {ex.Message}");
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
                var data = dataGridView1.SelectedRows[0].Cells["Data"].Value.GetType() == typeof(string)
                    ? DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Data"].Value.ToString())
                    : (DateTime)dataGridView1.SelectedRows[0].Cells["Data"].Value;

                var pedido = BancoDePedidos.BancoPedidos.GetPedidosProBalcao()
                    .FirstOrDefault(p => p.NomeCliente == nomeCliente && p.Data == data);

                if (pedido != null)
                {
                   
                    var novoStatus = ProximoStatus(pedido.Status);

                    
                    pedido.Status = novoStatus;

                    if (novoStatus == StatusPedido.Entregue)
                    {
                        BancoDePedidos.BancoPedidos.AtualizarStatusNoBalcao();
                    }                  
                    CarregarPedidos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para alterar o status.");
            }
        }
    }
}

