
namespace Cantina2._0
{
    partial class Tela_do_balcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_do_balcao));
            dataGridView1 = new DataGridView();
            itemPedidoBindingSource = new BindingSource(components);
            form1BindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnRetirar = new Button();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 282);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += MostrarComandaListBox;
            dataGridView1.CellContentClick += MostrarComandaListBox;
            // 
            // itemPedidoBindingSource
            // 
            itemPedidoBindingSource.DataSource = typeof(Models.ItemPedido);
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Tela_Chamada);
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.FromArgb(17, 25, 12);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(693, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 276);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 383);
            button1.Name = "button1";
            button1.Size = new Size(286, 76);
            button1.TabIndex = 2;
            button1.Text = "Atualizar Status";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAtualizarStatus;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(339, 392);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(286, 76);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar Pedido";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirarPedido_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir Semi Narrow", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(17, 25, 12);
            label5.Location = new Point(283, 24);
            label5.Name = "label5";
            label5.Size = new Size(106, 39);
            label5.TabIndex = 27;
            label5.Text = "Balcão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 25, 12);
            label1.Location = new Point(240, 24);
            label1.Name = "label1";
            label1.Size = new Size(37, 39);
            label1.TabIndex = 26;
            label1.Text = "X";
            // 
            // Tela_do_balcao
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(914, 480);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnRetirar);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 186);
            ForeColor = Color.FromArgb(120, 118, 100);
            Name = "Tela_do_balcao";
            Text = "Tela_do_Balcao";
            Load += Tela_do_balcao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dataGridView1;
        private BindingSource itemPedidoBindingSource;
        private BindingSource form1BindingSource;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private ListBox listBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnRetirar;
        private Label label5;
        private Label label1;
    }
}