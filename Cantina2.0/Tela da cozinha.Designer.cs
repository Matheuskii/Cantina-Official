namespace Cantina2._0
{
    partial class Tela_da_cozinha
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
            dataGridView1 = new DataGridView();
            itemPedidoBindingSource = new BindingSource(components);
            form1BindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(114, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 250);
            dataGridView1.TabIndex = 0;
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
            // Tela_da_cozinha
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(120, 118, 100);
            ClientSize = new Size(914, 480);
            Controls.Add(dataGridView1);
            Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 186);
            ForeColor = Color.FromArgb(120, 118, 100);
            Name = "Tela_da_cozinha";
            Text = "Tela_da_cozinha";
            Load += Tela_da_cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource itemPedidoBindingSource;
        private BindingSource form1BindingSource;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}