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
            List<string> categoriasDeletadas = new List<string>(); 
            if ( dvgCategoria.SelectedRows.Count > 0)
            {
                var seletedRows = dvgCategoria.SelectedRows;
                foreach ( DataGridViewRow seletedRow in seletedRows)
                {
                    categoriaDAL.DeletarCategoria(Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString()));
                    categoriasDeletadas.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregaGrid();
            MessageBox.Show($"Categoria(s): {string.Join(",", categoriasDeletadas)} deletada(s)");
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            List<string> categoriasModificadas = new List<string>();
            if (dvgCategoria.SelectedRows.Count > 0)
            {
                var seletedRows = dvgCategoria.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    int id = Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString());
                    string nome = seletedRow.Cells["Nome"].Value.ToString();
                    if (decimal.TryParse(seletedRow.Cells["ValorDiaria"].ToString(),out decimal valorDiaria))
                    {
                        MessageBox.Show("Valor da Diaria incorreto", "Locadora Classic");
                    }
                    
                    Categoria categoria = new Categoria(id,nome,valorDiaria);
                    categoriaDAL.AtualizarCategoria(categoria,id);
                    categoriasModificadas.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregaGrid();
            MessageBox.Show($"Categoria(s): {string.Join(",", categoriasModificadas)} modificadas(s)");
        }
    }
}
