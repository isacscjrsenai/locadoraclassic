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
            new FrmCadastroGenero().Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastroCategoria().Show();
        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmCadastroFilme().Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastroCliente().Show();
        }
    }
}
