namespace LocadoraClassic.View
{
    partial class FrmLocacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.maskedTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BannerFilme = new System.Windows.Forms.PictureBox();
            this.BtnConfirmarFilme = new System.Windows.Forms.Button();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLocados = new System.Windows.Forms.DataGridView();
            this.btnFinalizaLocacao = new System.Windows.Forms.Button();
            this.btnRemoveFilme = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDaDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.maskedTxtCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de Cliente por CPF";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(102, 33);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(974, 21);
            this.cbCliente.TabIndex = 16;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // maskedTxtCPF
            // 
            this.maskedTxtCPF.Location = new System.Drawing.Point(9, 32);
            this.maskedTxtCPF.Mask = "000.000.000-00";
            this.maskedTxtCPF.Name = "maskedTxtCPF";
            this.maskedTxtCPF.Size = new System.Drawing.Size(85, 20);
            this.maskedTxtCPF.TabIndex = 6;
            this.maskedTxtCPF.TextChanged += new System.EventHandler(this.maskedTxtCPF_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BannerFilme);
            this.groupBox2.Controls.Add(this.BtnConfirmarFilme);
            this.groupBox2.Controls.Add(this.dgvFilmes);
            this.groupBox2.Controls.Add(this.cbGenero);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomeFilme);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 395);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca Filme por Nome";
            // 
            // BannerFilme
            // 
            this.BannerFilme.Location = new System.Drawing.Point(7, 138);
            this.BannerFilme.Name = "BannerFilme";
            this.BannerFilme.Size = new System.Drawing.Size(236, 242);
            this.BannerFilme.TabIndex = 15;
            this.BannerFilme.TabStop = false;
            // 
            // BtnConfirmarFilme
            // 
            this.BtnConfirmarFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarFilme.Location = new System.Drawing.Point(322, 323);
            this.BtnConfirmarFilme.Name = "BtnConfirmarFilme";
            this.BtnConfirmarFilme.Size = new System.Drawing.Size(754, 57);
            this.BtnConfirmarFilme.TabIndex = 5;
            this.BtnConfirmarFilme.Text = "Confirmar Filme";
            this.BtnConfirmarFilme.UseVisualStyleBackColor = true;
            this.BtnConfirmarFilme.Click += new System.EventHandler(this.BtnConfirmarFilme_Click);
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(322, 16);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(754, 301);
            this.dgvFilmes.TabIndex = 14;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(6, 72);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(237, 21);
            this.cbGenero.TabIndex = 13;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(6, 32);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(237, 21);
            this.cbCategoria.TabIndex = 12;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(6, 112);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(237, 20);
            this.txtNomeFilme.TabIndex = 9;
            this.txtNomeFilme.TextChanged += new System.EventHandler(this.txtNomeFilme_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Filme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Locação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Devolução";
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Enabled = false;
            this.dtpLocacao.Location = new System.Drawing.Point(6, 30);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(237, 20);
            this.dtpLocacao.TabIndex = 16;
            this.dtpLocacao.ValueChanged += new System.EventHandler(this.dtpLocacao_ValueChanged);
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Enabled = false;
            this.dtpDevolucao.Location = new System.Drawing.Point(841, 30);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(233, 20);
            this.dtpDevolucao.TabIndex = 17;
            this.dtpDevolucao.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValorTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dgvLocados);
            this.groupBox3.Controls.Add(this.dtpLocacao);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpDevolucao);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1085, 327);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Locação";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Lime;
            this.txtValorTotal.Location = new System.Drawing.Point(974, 50);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(62, 29);
            this.txtValorTotal.TabIndex = 20;
            this.txtValorTotal.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(801, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor Total:R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lista de Filmes Locados";
            // 
            // dgvLocados
            // 
            this.dgvLocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Filme,
            this.Categoria,
            this.Genero,
            this.ValorDiaria,
            this.TotalDaDiaria});
            this.dgvLocados.Location = new System.Drawing.Point(6, 82);
            this.dgvLocados.Name = "dgvLocados";
            this.dgvLocados.Size = new System.Drawing.Size(1070, 239);
            this.dgvLocados.TabIndex = 16;
            this.dgvLocados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnFinalizaLocacao
            // 
            this.btnFinalizaLocacao.BackColor = System.Drawing.Color.Green;
            this.btnFinalizaLocacao.Enabled = false;
            this.btnFinalizaLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizaLocacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinalizaLocacao.Location = new System.Drawing.Point(207, 815);
            this.btnFinalizaLocacao.Name = "btnFinalizaLocacao";
            this.btnFinalizaLocacao.Size = new System.Drawing.Size(890, 34);
            this.btnFinalizaLocacao.TabIndex = 16;
            this.btnFinalizaLocacao.Text = "Finalizar Locação";
            this.btnFinalizaLocacao.UseVisualStyleBackColor = false;
            this.btnFinalizaLocacao.Click += new System.EventHandler(this.btnFinalizaLocacao_Click);
            // 
            // btnRemoveFilme
            // 
            this.btnRemoveFilme.Enabled = false;
            this.btnRemoveFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilme.Location = new System.Drawing.Point(19, 815);
            this.btnRemoveFilme.Name = "btnRemoveFilme";
            this.btnRemoveFilme.Size = new System.Drawing.Size(182, 34);
            this.btnRemoveFilme.TabIndex = 19;
            this.btnRemoveFilme.Text = "Remover";
            this.btnRemoveFilme.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Filme
            // 
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genêro";
            this.Genero.Name = "Genero";
            // 
            // ValorDiaria
            // 
            this.ValorDiaria.HeaderText = "Valor da Diária";
            this.ValorDiaria.Name = "ValorDiaria";
            // 
            // TotalDaDiaria
            // 
            this.TotalDaDiaria.HeaderText = "Total da Diárias";
            this.TotalDaDiaria.Name = "TotalDaDiaria";
            // 
            // FrmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 861);
            this.Controls.Add(this.btnRemoveFilme);
            this.Controls.Add(this.btnFinalizaLocacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLocacao";
            this.Text = "Locação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTxtCPF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BannerFilme;
        private System.Windows.Forms.Button BtnConfirmarFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLocados;
        private System.Windows.Forms.Button btnFinalizaLocacao;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnRemoveFilme;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDaDiaria;
    }
}