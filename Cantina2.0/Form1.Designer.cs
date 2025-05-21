namespace Cantina2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddButton = new Button();
            removeItem = new Button();
            ListDisp = new ListBox();
            Carrinho = new ListBox();
            label3 = new Label();
            label2 = new Label();
            boxQuantity = new NumericUpDown();
            boxRemove = new NumericUpDown();
            finishBtn = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)boxQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(243, 241, 238);
            AddButton.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            AddButton.Location = new Point(207, 148);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(138, 31);
            AddButton.TabIndex = 0;
            AddButton.Text = "Adicionar item";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // removeItem
            // 
            removeItem.BackColor = Color.FromArgb(243, 241, 238);
            removeItem.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            removeItem.Location = new Point(415, 148);
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(138, 31);
            removeItem.TabIndex = 1;
            removeItem.Text = "Remover item";
            removeItem.UseVisualStyleBackColor = false;
            removeItem.Click += removeItem_Click;
            // 
            // ListDisp
            // 
            ListDisp.BackColor = Color.FromArgb(243, 241, 238);
            ListDisp.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListDisp.FormattingEnabled = true;
            ListDisp.Location = new Point(12, 124);
            ListDisp.Name = "ListDisp";
            ListDisp.Size = new Size(189, 196);
            ListDisp.TabIndex = 4;
            // 
            // Carrinho
            // 
            Carrinho.BackColor = Color.FromArgb(243, 241, 238);
            Carrinho.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            Carrinho.FormattingEnabled = true;
            Carrinho.Location = new Point(559, 124);
            Carrinho.Name = "Carrinho";
            Carrinho.Size = new Size(229, 196);
            Carrinho.TabIndex = 6;
            Carrinho.SelectedIndexChanged += Carrinho_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 80);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 8;
            label3.Text = "Cardápio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(615, 80);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 9;
            label2.Text = "Carrinho";
            // 
            // boxQuantity
            // 
            boxQuantity.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxQuantity.Location = new Point(207, 185);
            boxQuantity.Name = "boxQuantity";
            boxQuantity.Size = new Size(138, 21);
            boxQuantity.TabIndex = 10;
            boxQuantity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // boxRemove
            // 
            boxRemove.BackColor = Color.FromArgb(243, 241, 238);
            boxRemove.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxRemove.Location = new Point(415, 185);
            boxRemove.Name = "boxRemove";
            boxRemove.Size = new Size(138, 21);
            boxRemove.TabIndex = 11;
            // 
            // finishBtn
            // 
            finishBtn.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finishBtn.ForeColor = Color.FromArgb(17, 25, 12);
            finishBtn.Location = new Point(313, 348);
            finishBtn.Name = "finishBtn";
            finishBtn.Size = new Size(121, 50);
            finishBtn.TabIndex = 12;
            finishBtn.Text = "Finalizar";
            finishBtn.UseVisualStyleBackColor = true;
            finishBtn.Click += finishBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(243, 241, 238);
            textBox1.Location = new Point(334, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(225, 255, 0);
            label4.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 25, 12);
            label4.Location = new Point(277, 70);
            label4.Name = "label4";
            label4.Size = new Size(51, 14);
            label4.TabIndex = 16;
            label4.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(243, 241, 238);
            comboBox1.ForeColor = Color.FromArgb(17, 25, 12);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "Débito", "Crédito", "Pix", "VA", "VR", "" });
            comboBox1.Location = new Point(313, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 64);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(finishBtn);
            Controls.Add(boxRemove);
            Controls.Add(boxQuantity);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Carrinho);
            Controls.Add(ListDisp);
            Controls.Add(removeItem);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)boxQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button removeItem;
        private ListBox ListDisp;
        private ListBox Carrinho;
        private Label label3;
        private Label label2;
        private NumericUpDown boxQuantity;
        private NumericUpDown boxRemove;
        private Button finishBtn;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
    }
}
