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
    public partial class FrmCadastroFilme : Form
    {
        GeneroDAL generoDAL = new GeneroDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        FilmeDAL filmeDAL = new FilmeDAL();
        public FrmCadastroFilme()
        {
            InitializeComponent();
            var listaGeneros = new List<string>();
            var listaCategorias = new List<string>();
            categoriaDAL.ObterCategorias().ToList().ForEach(categoria => listaCategorias.Add(categoria.Nome));
            generoDAL.ObterGeneros().ToList().ForEach(genero => listaGeneros.Add(genero.Nome));
            cbCategoria.DataSource = listaCategorias;
            cbGenero.DataSource = listaGeneros;

        }

        private void btnCadastrarFilme_Click(object sender, EventArgs e)
        {
            var nomeGenero = cbGenero.Text.ToString();
            var nomeCategoria = cbCategoria.Text.ToString();
            Genero genero = generoDAL.ObterGenero(nomeGenero);
            Categoria categoria = categoriaDAL.ObterCategoria(nomeCategoria);
            var nomeFilme = txtNomeFilme.Text;
            int duracaoFilme = int.Parse(maskedTxtDuracao.Text);
            string sinopseFilme = txtSinopse.Text;
            bool locadoFilme = checkBoxLocado.Checked;

        }
    }
}
