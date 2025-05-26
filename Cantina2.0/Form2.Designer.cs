namespace Cantina2._0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            nomeColuna = new ColumnHeader();
            pedidoColuna = new ColumnHeader();
            qntdColuna = new ColumnHeader();
            dataColuna = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.Location = new Point(571, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 64);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Info;
            listView1.Columns.AddRange(new ColumnHeader[] { nomeColuna, pedidoColuna, qntdColuna, dataColuna });
            listView1.Font = new Font("Agrandir Narrow Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.Location = new Point(12, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(299, 240);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // nomeColuna
            // 
            nomeColuna.Text = "Nome cliente ";
            // 
            // pedidoColuna
            // 
            pedidoColuna.Text = "Pedidos";
            // 
            // qntdColuna
            // 
            qntdColuna.Text = "Quantidade";
            // 
            // dataColuna
            // 
            dataColuna.Text = "Data/hora";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader nomeColuna;
        private ColumnHeader pedidoColuna;
        private ColumnHeader qntdColuna;
        private ColumnHeader dataColuna;
    }
}