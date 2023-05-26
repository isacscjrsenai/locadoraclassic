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
        GeneroDAL generoDAL = new GeneroDAL();
        public FrmCadastroGenero()
        {
            InitializeComponent();
            dgvGeneros.DataSource = new GeneroDAL().ObterGeneros().ToList();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var nomeGenero = txtNomeGenero.Text;
            Genero genero = new Genero(nomeGenero);
           
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

        private void btnDeletarGenero_Click(object sender, EventArgs e)
        {
            List<string> generosDeletados = new List<string>();

            if (dgvGeneros.SelectedCells.Count >= 0)
            {
                //seleciona todas as linhas das celulas selecionadas
                foreach (DataGridViewCell cell in dgvGeneros.SelectedCells)
                {
                    DataGridViewRow row = dgvGeneros.Rows[cell.RowIndex];
                    //seleciona a linha inteira
                    row.Selected = true;
                }
            }

            if (dgvGeneros.SelectedRows.Count > 0)
            {
                var seletedRows = dgvGeneros.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    generoDAL.DeletarGenero(Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString()));
                    generosDeletados.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregarGrid();
            MessageBox.Show($"Genero(s): {string.Join(",", generosDeletados)} deletado(s)");
        }

        private void btnModificarGenero_Click(object sender, EventArgs e)
        {
            List<string> categoriasModificadas = new List<string>();
            if (dgvGeneros.SelectedRows.Count > 0)
            {
                var seletedRows = dgvGeneros.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    int id = Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString());
                    string nome = seletedRow.Cells["Nome"].Value.ToString();
                    MessageBox.Show(id.ToString()+" "+nome);
                    Genero genero = new Genero(id, nome);
                    generoDAL.AtualizarGenero(genero);
                    categoriasModificadas.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregarGrid();
            MessageBox.Show($"Categoria(s): {string.Join(",", categoriasModificadas)} modificadas(s)");
        }

        private void dgvGeneros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGeneros.Rows[e.RowIndex];
                //seleciona a linha inteira
                row.Selected = true;
            }
            //verifica se tem alguma linha selecionada no DataGridView
            if (dgvGeneros.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvGeneros.SelectedRows[0];
                //Obtém o "id" da célula selecionada
                var id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                var nome = row.Cells["Nome"].Value.ToString();
                var genero = new Genero(id, nome);
                generoDAL.AtualizarGenero(genero);
            }
            CarregarGrid();
        }
    }
}
