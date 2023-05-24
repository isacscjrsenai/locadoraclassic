using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;
using LocadoraClassic.DAL;

namespace LocadoraClassic.View
{
    public partial class FrmCadastroCategoria : Form
    {
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        public FrmCadastroCategoria()
        {
            InitializeComponent();
            dvgCategoria.DataSource = categoriaDAL.ObterCategorias().ToList();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var nomeCategoria = txtNomeCategoria.Text;
            var valorDiaria = decimal.Parse(txtValorDiaria.Text);
            Categoria categoria = new Categoria();
            categoria.Nome = nomeCategoria;
            categoria.ValorDiaria = valorDiaria;
            categoriaDAL.InserirCategoria(categoria);
            CarregaGrid();
            txtNomeCategoria.Text = "";
            txtValorDiaria.Text = "";
            MessageBox.Show($"Categoria {nomeCategoria} salva no sucesso.","Locadora Classic");
        }
        private void CarregaGrid()
        {
            dvgCategoria.DataSource = categoriaDAL.ObterCategorias().ToList();
            dvgCategoria.Refresh();
        }

        private void txtValorDiaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletarCategoria_Click(object sender, EventArgs e)
        {
            var categorias = dvgCategoria.SelectedRows;
            categorias.Cast<Categoria>().ToList().ForEach(categoria => { categoriaDAL.DeletarCategoria(categoria); }) ;
            MessageBox.Show($"Categoria(s): {string.Join(",",categorias.Cast<Categoria>().ToList())} deletada(s)");
        }
    }
}
