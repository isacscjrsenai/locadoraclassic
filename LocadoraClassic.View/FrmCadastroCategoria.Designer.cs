namespace LocadoraClassic.View
{
    partial class FrmCadastroCategoria
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
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgCategoria = new System.Windows.Forms.DataGridView();
            this.btnDeletarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(512, 101);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCategoria.TabIndex = 0;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(12, 64);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(100, 20);
            this.txtValorDiaria.TabIndex = 1;
            this.txtValorDiaria.TextChanged += new System.EventHandler(this.txtValorDiaria_TextChanged);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(12, 25);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(575, 20);
            this.txtNomeCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor da Diária";
            // 
            // dvgCategoria
            // 
            this.dvgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategoria.Location = new System.Drawing.Point(12, 130);
            this.dvgCategoria.Name = "dvgCategoria";
            this.dvgCategoria.Size = new System.Drawing.Size(575, 312);
            this.dvgCategoria.TabIndex = 5;
            // 
            // btnDeletarCategoria
            // 
            this.btnDeletarCategoria.Location = new System.Drawing.Point(512, 448);
            this.btnDeletarCategoria.Name = "btnDeletarCategoria";
            this.btnDeletarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCategoria.TabIndex = 6;
            this.btnDeletarCategoria.Text = "Deletar";
            this.btnDeletarCategoria.UseVisualStyleBackColor = true;
            this.btnDeletarCategoria.Click += new System.EventHandler(this.btnDeletarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(431, 448);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 7;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 481);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnDeletarCategoria);
            this.Controls.Add(this.dvgCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Name = "FrmCadastroCategoria";
            this.Text = "Locadora Classic - Cadastro de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgCategoria;
        private System.Windows.Forms.Button btnDeletarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
    }
}