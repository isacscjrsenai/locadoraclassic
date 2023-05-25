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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTxtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.checkBoxLocado = new System.Windows.Forms.CheckBox();
            this.btnCadastrarFilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeletarFilme = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(407, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 413);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // maskedTxtDuracao
            // 
            this.maskedTxtDuracao.Location = new System.Drawing.Point(12, 144);
            this.maskedTxtDuracao.Mask = "90:00";
            this.maskedTxtDuracao.Name = "maskedTxtDuracao";
            this.maskedTxtDuracao.Size = new System.Drawing.Size(35, 20);
            this.maskedTxtDuracao.TabIndex = 8;
            this.maskedTxtDuracao.ValidatingType = typeof(System.DateTime);
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
            this.btnCadastrarFilme.Location = new System.Drawing.Point(12, 444);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 511);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 223);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnDeletarFilme
            // 
            this.btnDeletarFilme.Location = new System.Drawing.Point(710, 745);
            this.btnDeletarFilme.Name = "btnDeletarFilme";
            this.btnDeletarFilme.Size = new System.Drawing.Size(78, 30);
            this.btnDeletarFilme.TabIndex = 15;
            this.btnDeletarFilme.Text = "Deletar";
            this.btnDeletarFilme.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(626, 745);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 30);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 787);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDeletarFilme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarFilme);
            this.Controls.Add(this.checkBoxLocado);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtDuracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFilme";
            this.Text = "LOCADORA CLASSIC - Cadastro de Filme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTxtDuracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.CheckBox checkBoxLocado;
        private System.Windows.Forms.Button btnCadastrarFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletarFilme;
        private System.Windows.Forms.Button btnModificar;
    }
}