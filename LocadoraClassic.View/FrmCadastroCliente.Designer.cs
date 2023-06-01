namespace LocadoraClassic.View
{
    partial class FrmCadastroCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.maskedTxtRGCliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTxtCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTxtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(388, 25);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(415, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // maskedTxtRGCliente
            // 
            this.maskedTxtRGCliente.Location = new System.Drawing.Point(388, 64);
            this.maskedTxtRGCliente.Name = "maskedTxtRGCliente";
            this.maskedTxtRGCliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtRGCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // maskedTxtCPFCliente
            // 
            this.maskedTxtCPFCliente.Location = new System.Drawing.Point(494, 64);
            this.maskedTxtCPFCliente.Mask = "000,000,000-00";
            this.maskedTxtCPFCliente.Name = "maskedTxtCPFCliente";
            this.maskedTxtCPFCliente.Size = new System.Drawing.Size(85, 20);
            this.maskedTxtCPFCliente.TabIndex = 5;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(388, 103);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(413, 20);
            this.txtEnderecoCliente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // maskedTxtTelefoneCliente
            // 
            this.maskedTxtTelefoneCliente.Location = new System.Drawing.Point(585, 64);
            this.maskedTxtTelefoneCliente.Mask = "(99) 00000-0000";
            this.maskedTxtTelefoneCliente.Name = "maskedTxtTelefoneCliente";
            this.maskedTxtTelefoneCliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtTelefoneCliente.TabIndex = 9;
            // 
            // dvgCliente
            // 
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.Location = new System.Drawing.Point(15, 158);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.Size = new System.Drawing.Size(786, 457);
            this.dvgCliente.TabIndex = 11;
            this.dvgCliente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellValueChanged);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Location = new System.Drawing.Point(726, 621);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCliente.TabIndex = 12;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 656);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.dvgCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtTelefoneCliente);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTxtCPFCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTxtRGCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Cliente - Locadora Classic";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.MaskedTextBox maskedTxtRGCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTxtCPFCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefoneCliente;
        private System.Windows.Forms.DataGridView dvgCliente;
        private System.Windows.Forms.Button btnDeletarCliente;
    }
}