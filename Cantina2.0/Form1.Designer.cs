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
            AddButton = new Button();
            removeItem = new Button();
            ItemSelected = new ListBox();
            label1 = new Label();
            Carrinho = new ListBox();
            label3 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            AddButton.Location = new Point(241, 133);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(138, 72);
            AddButton.TabIndex = 0;
            AddButton.Text = "Adicionar item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // removeItem
            // 
            removeItem.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            removeItem.Location = new Point(448, 353);
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(146, 68);
            removeItem.TabIndex = 1;
            removeItem.Text = "Remover item";
            removeItem.UseVisualStyleBackColor = true;
            // 
            // ItemSelected
            // 
            ItemSelected.BackColor = Color.FromArgb(243, 241, 238);
            ItemSelected.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemSelected.FormattingEnabled = true;
            ItemSelected.Location = new Point(12, 133);
            ItemSelected.Name = "ItemSelected";
            ItemSelected.Size = new Size(176, 196);
            ItemSelected.TabIndex = 4;
            ItemSelected.SelectedIndexChanged += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 42);
            label1.TabIndex = 5;
            label1.Text = "Bolt-Cantina";
            label1.Click += label1_Click;
            // 
            // Carrinho
            // 
            Carrinho.BackColor = Color.FromArgb(243, 241, 238);
            Carrinho.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            Carrinho.FormattingEnabled = true;
            Carrinho.Location = new Point(613, 130);
            Carrinho.Name = "Carrinho";
            Carrinho.Size = new Size(175, 196);
            Carrinho.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 80);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 8;
            label3.Text = "Cardápio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(641, 80);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 9;
            label2.Text = "Carrinho";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            numericUpDown1.Location = new Point(241, 236);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(149, 21);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Carrinho);
            Controls.Add(label1);
            Controls.Add(ItemSelected);
            Controls.Add(removeItem);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button removeItem;
        private ListBox ItemSelected;
        private Label label1;
        private ListBox Carrinho;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
    }
}
