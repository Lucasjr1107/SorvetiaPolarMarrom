namespace Sorvetia_PolarMarrom
{
    partial class MenuSorveteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstItensPedido = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.btnConcluirPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Itens no Produto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(3, 79);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 25);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(3, 110);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(402, 22);
            this.txtCPF.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 22);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "a";
            // 
            // lstItensPedido
            // 
            this.lstItensPedido.FormattingEnabled = true;
            this.lstItensPedido.ItemHeight = 16;
            this.lstItensPedido.Location = new System.Drawing.Point(481, 48);
            this.lstItensPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstItensPedido.Name = "lstItensPedido";
            this.lstItensPedido.Size = new System.Drawing.Size(383, 436);
            this.lstItensPedido.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Location = new System.Drawing.Point(26, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 241);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Menu;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantidade:";
            this.label4.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(5, 73);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(135, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(5, 29);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(127, 20);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Data do pedido:";
            this.lblNomeCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Informaçoes";
            this.label5.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Menu;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorTotal.Location = new System.Drawing.Point(5, 111);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(95, 20);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.Location = new System.Drawing.Point(107, 468);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(116, 36);
            this.btnAddPedido.TabIndex = 11;
            this.btnAddPedido.Text = "Add Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = false;
            // 
            // btnConcluirPedido
            // 
            this.btnConcluirPedido.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConcluirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirPedido.Location = new System.Drawing.Point(212, 135);
            this.btnConcluirPedido.Name = "btnConcluirPedido";
            this.btnConcluirPedido.Size = new System.Drawing.Size(88, 32);
            this.btnConcluirPedido.TabIndex = 12;
            this.btnConcluirPedido.Text = "Concluir pedido";
            this.btnConcluirPedido.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(306, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Coral;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(229, 470);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(99, 32);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(332, 470);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 31);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtCPF);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.lblCPF);
            this.panel2.Controls.Add(this.btnConcluirPedido);
            this.panel2.Location = new System.Drawing.Point(26, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 171);
            this.panel2.TabIndex = 16;
            // 
            // MenuSorveteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(886, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstItensPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuSorveteria";
            this.Text = "Meno da Sorveteria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstItensPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnConcluirPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
    }
}