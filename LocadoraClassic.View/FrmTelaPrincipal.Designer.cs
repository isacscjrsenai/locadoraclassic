namespace LocadoraClassic.View
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relátoriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(147, 561);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.filmesToolStripMenuItem1,
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(140, 33);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(228, 70);
            this.generoToolStripMenuItem.Text = "Gênero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(228, 70);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem1
            // 
            this.filmesToolStripMenuItem1.Image = global::LocadoraClassic.View.Properties.Resources.rolo_de_filme;
            this.filmesToolStripMenuItem1.Name = "filmesToolStripMenuItem1";
            this.filmesToolStripMenuItem1.Size = new System.Drawing.Size(228, 70);
            this.filmesToolStripMenuItem1.Text = "Filmes";
            this.filmesToolStripMenuItem1.Click += new System.EventHandler(this.filmesToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::LocadoraClassic.View.Properties.Resources.cliente;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(228, 70);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatórioDiárioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(140, 33);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar Locação";
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relátoriosToolStripMenuItem
            // 
            this.relátoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.faturamentoDoDiaToolStripMenuItem,
            this.faturamentoDoMêsToolStripMenuItem});
            this.relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            this.relátoriosToolStripMenuItem.Size = new System.Drawing.Size(140, 33);
            this.relátoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            // 
            // faturamentoDoMêsToolStripMenuItem
            // 
            this.faturamentoDoMêsToolStripMenuItem.Name = "faturamentoDoMêsToolStripMenuItem";
            this.faturamentoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.faturamentoDoMêsToolStripMenuItem.Text = "Faturamento do Mês";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem,
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(140, 33);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // gráficoPizzaDeClientesPorEndereçoToolStripMenuItem
            // 
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Name = "gráficoPizzaDeClientesPorEndereçoToolStripMenuItem";
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Size = new System.Drawing.Size(480, 34);
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Text = "Gráfico Pizza de Clientes por Endereço";
            // 
            // gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem
            // 
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Name = "gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem";
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(480, 34);
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Text = "Gráfico de Barra de Atrasados por Mês";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LocadoraClassic.View.Properties.Resources.charlie_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 600);
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora Classic";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoPizzaDeClientesPorEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    }
}

