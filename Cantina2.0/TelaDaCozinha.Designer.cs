namespace Cantina2._0
{
    partial class TelaBalcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBalcao));
            pictureBox1 = new PictureBox();
            form1BindingSource = new BindingSource(components);
            form1BindingSource1 = new BindingSource(components);
            form1BindingSource2 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            btnEntregue = new Button();
            label5 = new Label();
            label1 = new Label();
            btnRetirar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 64);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(Form1);
            // 
            // form1BindingSource2
            // 
            form1BindingSource2.DataSource = typeof(Form1);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 241, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 218);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = Color.FromArgb(243, 241, 238);
            btnEntregue.Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregue.Location = new Point(40, 324);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(113, 88);
            btnEntregue.TabIndex = 23;
            btnEntregue.Text = "Mudar o status";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir Semi Narrow", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(274, 24);
            label5.Name = "label5";
            label5.Size = new Size(122, 39);
            label5.TabIndex = 25;
            label5.Text = "Cozinha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 24);
            label1.Name = "label1";
            label1.Size = new Size(37, 39);
            label1.TabIndex = 24;
            label1.Text = "X";
            // 
            // btnRetirar
            // 
            btnRetirar.BackColor = Color.FromArgb(243, 241, 238);
            btnRetirar.Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirar.Location = new Point(222, 324);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(113, 88);
            btnRetirar.TabIndex = 26;
            btnRetirar.Text = "Retirar Concluido";
            btnRetirar.UseVisualStyleBackColor = false;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // TelaBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetirar);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnEntregue);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "TelaBalcao";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private BindingSource form1BindingSource;
        private BindingSource form1BindingSource1;
        private BindingSource form1BindingSource2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnEntregue;
        private Label label5;
        private Label label1;
        private Button btnRetirar;
    }
}