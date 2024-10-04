namespace Sorvetia_PolarMarrom
{
    partial class AddPedido
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
            this.lblAdicionarPedido = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPrdt = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionarPedido
            // 
            this.lblAdicionarPedido.AutoSize = true;
            this.lblAdicionarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarPedido.Location = new System.Drawing.Point(135, 33);
            this.lblAdicionarPedido.Name = "lblAdicionarPedido";
            this.lblAdicionarPedido.Size = new System.Drawing.Size(331, 32);
            this.lblAdicionarPedido.TabIndex = 0;
            this.lblAdicionarPedido.Text = "Adicionar item no Pedido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lblPrdt
            // 
            this.lblPrdt.AutoSize = true;
            this.lblPrdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdt.Location = new System.Drawing.Point(46, 86);
            this.lblPrdt.Name = "lblPrdt";
            this.lblPrdt.Size = new System.Drawing.Size(96, 25);
            this.lblPrdt.TabIndex = 2;
            this.lblPrdt.Text = "Produtos:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 191);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(254, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(46, 163);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(120, 25);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 179);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // AddPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblPrdt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAdicionarPedido);
            this.Name = "AddPedido";
            this.Text = "AddPedido";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarPedido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPrdt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}