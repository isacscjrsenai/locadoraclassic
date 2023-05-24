using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmCadastroGenero frmCadastroGenero = new FrmCadastroGenero();
            frmCadastroGenero.MdiParent = this;
            frmCadastroGenero.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
            frmCadastroCategoria.MdiParent = this;
            frmCadastroCategoria.Show();
        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastroFilme frmCadastroFilme = new FrmCadastroFilme();
            frmCadastroFilme.MdiParent = this;
            frmCadastroFilme.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente =new FrmCadastroCliente();
            frmCadastroCliente.MdiParent = this;
            frmCadastroCliente.Show();
        }

        private void realizarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao frmLocacao = new FrmLocacao();
            frmLocacao.MdiParent = this;
            frmLocacao.Show();
        }
    }
}
