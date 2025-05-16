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
            boxQuantity = new NumericUpDown();
            boxRemove = new NumericUpDown();
            finishBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)boxQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxRemove).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            AddButton.Location = new Point(207, 148);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(138, 31);
            AddButton.TabIndex = 0;
            AddButton.Text = "Adicionar item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // removeItem
            // 
            removeItem.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            removeItem.Location = new Point(415, 148);
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(138, 31);
            removeItem.TabIndex = 1;
            removeItem.Text = "Remover item";
            removeItem.UseVisualStyleBackColor = true;
            removeItem.Click += removeItem_Click;
            // 
            // ItemSelected
            // 
            ItemSelected.BackColor = Color.FromArgb(243, 241, 238);
            ItemSelected.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemSelected.FormattingEnabled = true;
            ItemSelected.Location = new Point(12, 124);
            ItemSelected.Name = "ItemSelected";
            ItemSelected.Size = new Size(189, 196);
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
            Carrinho.Location = new Point(563, 124);
            Carrinho.Name = "Carrinho";
            Carrinho.Size = new Size(225, 196);
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
            label2.Location = new Point(648, 80);
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
            boxRemove.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxRemove.Location = new Point(415, 185);
            boxRemove.Name = "boxRemove";
            boxRemove.Size = new Size(138, 21);
            boxRemove.TabIndex = 11;
            // 
            // finishBtn
            // 
            finishBtn.Location = new Point(334, 236);
            finishBtn.Name = "finishBtn";
            finishBtn.Size = new Size(103, 50);
            finishBtn.TabIndex = 12;
            finishBtn.Text = "Finalizar";
            finishBtn.UseVisualStyleBackColor = true;
            finishBtn.Click += finishBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(674, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(77, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(591, 9);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(77, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(finishBtn);
            Controls.Add(boxRemove);
            Controls.Add(boxQuantity);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Carrinho);
            Controls.Add(label1);
            Controls.Add(ItemSelected);
            Controls.Add(removeItem);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)boxQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxRemove).EndInit();
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
        private NumericUpDown boxQuantity;
        private NumericUpDown boxRemove;
        private Button finishBtn;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}
