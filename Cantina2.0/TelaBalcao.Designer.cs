
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
            dataGridView1.CellClick += DisplayCustomerOrderDetails;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // itemPedidoBindingSource
            // 
            itemPedidoBindingSource.DataSource = typeof(Models.ItemPedido);
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(693, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 276);
            listBox1.TabIndex = 1;
            
            // 
            // button1
            // 
            button1.Location = new Point(12, 383);
            button1.Name = "button1";
            button1.Size = new Size(286, 76);
            button1.TabIndex = 2;
            button1.Text = "Change status";
            button1.UseVisualStyleBackColor = true;
            button1.Click += UpdateOrderStatus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 51);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(348, 392);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(286, 76);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Change status";
            btnRetirar.UseVisualStyleBackColor = true;
           
            // 
            // Tela_da_cozinha
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(914, 480);
            Controls.Add(btnRetirar);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 186);
            ForeColor = Color.FromArgb(120, 118, 100);
            Name = "Tela_da_cozinha";
            Text = "Tela_da_cozinha";
            Load += Tela_da_cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
    }
}