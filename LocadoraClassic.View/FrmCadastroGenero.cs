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
                    generoDAL.AtualizarGenero(genero, id);
                    categoriasModificadas.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregarGrid();
            MessageBox.Show($"Categoria(s): {string.Join(",", categoriasModificadas)} modificadas(s)");
        }
    }
}
