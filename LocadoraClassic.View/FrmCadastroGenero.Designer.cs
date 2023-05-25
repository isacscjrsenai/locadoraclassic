namespace LocadoraClassic.View
{
    partial class FrmCadastroGenero
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
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.btnDeletarGenero = new System.Windows.Forms.Button();
            this.btnModificarGenero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(12, 25);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(315, 20);
            this.txtNomeGenero.TabIndex = 5;
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(252, 65);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCategoria.TabIndex = 4;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Location = new System.Drawing.Point(15, 115);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.Size = new System.Drawing.Size(312, 359);
            this.dgvGeneros.TabIndex = 7;
            // 
            // btnDeletarGenero
            // 
            this.btnDeletarGenero.Location = new System.Drawing.Point(252, 480);
            this.btnDeletarGenero.Name = "btnDeletarGenero";
            this.btnDeletarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarGenero.TabIndex = 8;
            this.btnDeletarGenero.Text = "Deletar";
            this.btnDeletarGenero.UseVisualStyleBackColor = true;
            this.btnDeletarGenero.Click += new System.EventHandler(this.btnDeletarGenero_Click);
            // 
            // btnModificarGenero
            // 
            this.btnModificarGenero.Location = new System.Drawing.Point(171, 480);
            this.btnModificarGenero.Name = "btnModificarGenero";
            this.btnModificarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnModificarGenero.TabIndex = 9;
            this.btnModificarGenero.Text = "Modificar";
            this.btnModificarGenero.UseVisualStyleBackColor = true;
            this.btnModificarGenero.Click += new System.EventHandler(this.btnModificarGenero_Click);
            // 
            // FrmCadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 516);
            this.Controls.Add(this.btnModificarGenero);
            this.Controls.Add(this.btnDeletarGenero);
            this.Controls.Add(this.dgvGeneros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Name = "FrmCadastroGenero";
            this.Text = "Locadora Classic - Cadastro de Gênero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Button btnDeletarGenero;
        private System.Windows.Forms.Button btnModificarGenero;
    }
}