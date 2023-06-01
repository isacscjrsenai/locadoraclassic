using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using LocadoraClassic.API;
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
            dgvFilme.DataSource = filmeDAL.GetFilmes();

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
            Filme filme = new Filme();
            filme.Nome = nomeFilme;
            filme.Genero = genero;
            filme.Categoria = categoria;
            filme.Duracao = duracaoFilme;
            filme.Sinopse = sinopseFilme;
            filme.Locado = locadoFilme;
            filmeDAL.InserirFilme(filme);
            CarregarGrid();
            MessageBox.Show($"Filme {filme.Nome} adicionado","Locadora Classic");
            
        }
        private void CarregarGrid()
        {
            dgvFilme.DataSource = filmeDAL.GetFilmes();
            dgvFilme.Refresh();
        }

        private void FrmCadastroFilme_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnDeletarFilme_Click(object sender, EventArgs e)
        {
            List<string> filmesDeletados = new List<string>();

            if (dgvFilme.SelectedCells.Count >= 0)
            {
                //seleciona todas as linhas das celulas selecionadas
                foreach (DataGridViewCell cell in dgvFilme.SelectedCells)
                {
                    DataGridViewRow row = dgvFilme.Rows[cell.RowIndex];
                    //seleciona a linha inteira
                    row.Selected = true;
                }
            }

            if (dgvFilme.SelectedRows.Count > 0)
            {
                var seletedRows = dgvFilme.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    filmeDAL.DeletarFilme(Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString()));
                    filmesDeletados.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregarGrid();
            MessageBox.Show($"Genero(s): {string.Join(",", filmesDeletados)} deletado(s)");
        }

        private void dgvFilme_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFilme.Rows[e.RowIndex];
                //seleciona a linha inteira
                row.Selected = true;
            }
            //verifica se tem alguma linha selecionada no DataGridView
            if (dgvFilme.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvFilme.SelectedRows[0];
                //Obtém o "id" da célula selecionada
                var id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                var nome = row.Cells["Nome"].Value.ToString();
                var genero = (Genero)row.Cells["Genero"].Value;
                var categoria = (Categoria)row.Cells["Categoria"].Value;
                var sinopse = row.Cells["Sinopse"].Value.ToString();
                var locado = Convert.ToBoolean(row.Cells["Locado"].Value);
                var duracao = Convert.ToInt32(row.Cells["Duracao"].Value);
                var filme = new Filme(id, genero, categoria,nome,sinopse,locado,duracao);
                filmeDAL.AtualizarFilme(filme);
            }
            CarregarGrid();
        }

        private void btnPesquisaFilme_Click(object sender, EventArgs e)
        {
            var NomeFilme = txtNomeFilme.Text;
            var titleData = new ImdbApi().GetTitle(NomeFilme);
            MessageBox.Show($"{titleData.Result.Results[0].Title}");
        }
    }
}
