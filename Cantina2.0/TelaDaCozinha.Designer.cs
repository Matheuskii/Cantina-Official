﻿namespace Cantina2._0
{
    partial class TelaCozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCozinha));
            form1BindingSource = new BindingSource(components);
            form1BindingSource1 = new BindingSource(components);
            form1BindingSource2 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            btnEntregue = new Button();
            label5 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Tela_Chamada);
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(Tela_Chamada);
            // 
            // form1BindingSource2
            // 
            form1BindingSource2.DataSource = typeof(Tela_Chamada);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 241, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 218);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += MostrarComandaListBox;
            dataGridView1.CellContentClick += MostrarComandaListBox;
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
            btnEntregue.Click += btnStatus_Click;
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
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(243, 241, 238);
            listBox1.Font = new Font("Agrandir Narrow Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(17, 25, 12);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(582, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 260);
            listBox1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 63);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // TelaCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnEntregue);
            Controls.Add(dataGridView1);
            Name = "TelaCozinha";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}