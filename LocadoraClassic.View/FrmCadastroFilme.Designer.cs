namespace LocadoraClassic.View
{
    partial class FrmCadastroFilme
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.BannerFilme = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.checkBoxLocado = new System.Windows.Forms.CheckBox();
            this.btnCadastrarFilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFilme = new System.Windows.Forms.DataGridView();
            this.btnDeletarFilme = new System.Windows.Forms.Button();
            this.maskedTxtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPossibilidades = new System.Windows.Forms.DataGridView();
            this.labelPossibilidade = new System.Windows.Forms.Label();
            this.btnPesquisaFilme = new System.Windows.Forms.Button();
            this.trailer = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.BannerFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(15, 25);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(359, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gênero";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(15, 65);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(359, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Filme";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(15, 105);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(359, 20);
            this.txtNomeFilme.TabIndex = 5;
            // 
            // BannerFilme
            // 
            this.BannerFilme.InitialImage = global::LocadoraClassic.View.Properties.Resources.charlie;
            this.BannerFilme.Location = new System.Drawing.Point(417, 25);
            this.BannerFilme.Name = "BannerFilme";
            this.BannerFilme.Size = new System.Drawing.Size(371, 390);
            this.BannerFilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerFilme.TabIndex = 6;
            this.BannerFilme.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sinopse";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(12, 183);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(362, 232);
            this.txtSinopse.TabIndex = 10;
            // 
            // checkBoxLocado
            // 
            this.checkBoxLocado.AutoSize = true;
            this.checkBoxLocado.Location = new System.Drawing.Point(15, 421);
            this.checkBoxLocado.Name = "checkBoxLocado";
            this.checkBoxLocado.Size = new System.Drawing.Size(62, 17);
            this.checkBoxLocado.TabIndex = 11;
            this.checkBoxLocado.Text = "Locado";
            this.checkBoxLocado.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFilme
            // 
            this.btnCadastrarFilme.Location = new System.Drawing.Point(12, 593);
            this.btnCadastrarFilme.Name = "btnCadastrarFilme";
            this.btnCadastrarFilme.Size = new System.Drawing.Size(776, 60);
            this.btnCadastrarFilme.TabIndex = 12;
            this.btnCadastrarFilme.Text = "Cadastrar";
            this.btnCadastrarFilme.UseVisualStyleBackColor = true;
            this.btnCadastrarFilme.Click += new System.EventHandler(this.btnCadastrarFilme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Banner";
            // 
            // dgvFilme
            // 
            this.dgvFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilme.Location = new System.Drawing.Point(12, 660);
            this.dgvFilme.Name = "dgvFilme";
            this.dgvFilme.Size = new System.Drawing.Size(776, 223);
            this.dgvFilme.TabIndex = 14;
            this.dgvFilme.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_CellValueChanged);
            // 
            // btnDeletarFilme
            // 
            this.btnDeletarFilme.Location = new System.Drawing.Point(710, 894);
            this.btnDeletarFilme.Name = "btnDeletarFilme";
            this.btnDeletarFilme.Size = new System.Drawing.Size(78, 30);
            this.btnDeletarFilme.TabIndex = 15;
            this.btnDeletarFilme.Text = "Deletar";
            this.btnDeletarFilme.UseVisualStyleBackColor = true;
            this.btnDeletarFilme.Click += new System.EventHandler(this.btnDeletarFilme_Click);
            // 
            // maskedTxtDuracao
            // 
            this.maskedTxtDuracao.Location = new System.Drawing.Point(12, 144);
            this.maskedTxtDuracao.Mask = "000";
            this.maskedTxtDuracao.Name = "maskedTxtDuracao";
            this.maskedTxtDuracao.Size = new System.Drawing.Size(35, 20);
            this.maskedTxtDuracao.TabIndex = 8;
            this.maskedTxtDuracao.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Min.";
            // 
            // dgvPossibilidades
            // 
            this.dgvPossibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPossibilidades.Location = new System.Drawing.Point(12, 444);
            this.dgvPossibilidades.Name = "dgvPossibilidades";
            this.dgvPossibilidades.Size = new System.Drawing.Size(776, 136);
            this.dgvPossibilidades.TabIndex = 17;
            this.dgvPossibilidades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPossibilidades_CellMouseClick);
            // 
            // labelPossibilidade
            // 
            this.labelPossibilidade.AutoSize = true;
            this.labelPossibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPossibilidade.Location = new System.Drawing.Point(677, 420);
            this.labelPossibilidade.Name = "labelPossibilidade";
            this.labelPossibilidade.Size = new System.Drawing.Size(111, 16);
            this.labelPossibilidade.TabIndex = 18;
            this.labelPossibilidade.Text = "Possibilidades";
            // 
            // btnPesquisaFilme
            // 
            this.btnPesquisaFilme.Location = new System.Drawing.Point(243, 139);
            this.btnPesquisaFilme.Name = "btnPesquisaFilme";
            this.btnPesquisaFilme.Size = new System.Drawing.Size(131, 29);
            this.btnPesquisaFilme.TabIndex = 19;
            this.btnPesquisaFilme.Text = "Pesquisar Filme";
            this.btnPesquisaFilme.UseVisualStyleBackColor = true;
            this.btnPesquisaFilme.Click += new System.EventHandler(this.btnPesquisaFilme_Click);
            // 
            // trailer
            // 
            this.trailer.Location = new System.Drawing.Point(795, 25);
            this.trailer.MinimumSize = new System.Drawing.Size(20, 20);
            this.trailer.Name = "trailer";
            this.trailer.Size = new System.Drawing.Size(872, 502);
            this.trailer.TabIndex = 20;
            // 
            // FrmCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 936);
            this.Controls.Add(this.trailer);
            this.Controls.Add(this.btnPesquisaFilme);
            this.Controls.Add(this.labelPossibilidade);
            this.Controls.Add(this.dgvPossibilidades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeletarFilme);
            this.Controls.Add(this.dgvFilme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarFilme);
            this.Controls.Add(this.checkBoxLocado);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtDuracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BannerFilme);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFilme";
            this.Text = "LOCADORA CLASSIC - Cadastro de Filme";
            this.Load += new System.EventHandler(this.FrmCadastroFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BannerFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.PictureBox BannerFilme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.CheckBox checkBoxLocado;
        private System.Windows.Forms.Button btnCadastrarFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFilme;
        private System.Windows.Forms.Button btnDeletarFilme;
        private System.Windows.Forms.MaskedTextBox maskedTxtDuracao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPossibilidades;
        private System.Windows.Forms.Label labelPossibilidade;
        private System.Windows.Forms.Button btnPesquisaFilme;
        private System.Windows.Forms.WebBrowser trailer;
    }
}