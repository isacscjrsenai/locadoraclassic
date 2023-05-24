using LocadoraClassic.DAL;
using LocadoraClassic.VO;
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
    public partial class FrmCadastroGenero : Form
    {
        public FrmCadastroGenero()
        {
            InitializeComponent();
            dgvGeneros.DataSource = new GeneroDAL().ObterGeneros().ToList();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var nomeGenero = txtNomeGenero.Text;
            Genero genero = new Genero(nomeGenero);
            GeneroDAL generoDAL = new GeneroDAL();
            //Insere no banco de dados
            generoDAL.InserirGenero(genero);
            txtNomeGenero.Text = "";
            CarregarGrid();
            MessageBox.Show($"Genêro {nomeGenero} inserido");
        }
        private void CarregarGrid()
        {
            dgvGeneros.DataSource = new GeneroDAL().ObterGeneros().ToList();
            dgvGeneros.Refresh();
        }
    }
}
