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
    public partial class FrmLocacao : Form
    {
        GeneroDAL generoDAL = new GeneroDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        FilmeDAL filmeDAL = new FilmeDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        LocacaoDAL locacaoDAL = new LocacaoDAL();
        List<Dictionary<string,string>>filmesLocados = new List<Dictionary<string, string>>();
        private TimeSpan tempoDeLocacao = TimeSpan.FromDays(1);
        decimal valorTotal = 0;
        public FrmLocacao()
        {
            InitializeComponent();
            var listaGeneros = generoDAL.ObterGeneros();
            var listaCategorias = categoriaDAL.ObterCategorias();
            cbCategoria.DataSource = listaCategorias;
            cbGenero.DataSource = listaGeneros;
            dtpDevolucao.Value.AddDays(1);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConfirmarFilme_Click(object sender, EventArgs e)
        {
            List<Filme> filmesSelecionados = new List<Filme>();

            if (dgvFilmes.SelectedCells.Count >= 0)
            {
                //seleciona todas as linhas das celulas selecionadas
                foreach (DataGridViewCell cell in dgvFilmes.SelectedCells)
                {
                    DataGridViewRow row = dgvFilmes.Rows[cell.RowIndex];
                    //seleciona a linha inteira
                    row.Selected = true;
                }
            }

            if (dgvFilmes.SelectedRows.Count > 0)
            {
                var seletedRows = dgvFilmes.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    var filme = filmeDAL.ObterFilme(Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString()));
                    if (filme.Locado)
                    {
                        MessageBox.Show($"O filme {filme.Nome} está locado","Locadora Classic");
                    }
                    else
                    {
                        filmesSelecionados.Add(filme);
                    }
                }
            }
            CarregaGridLocados(filmesSelecionados);
            dtpLocacao.Enabled = true;
            dtpDevolucao.Enabled = true;
            AtualizaValorTotal();

            //MessageBox.Show($"Filme(s): {string.Join(",", filmesSelecionados)} selecionado(s)");
        }

        private void CarregaGridLocados(List<Filme> filmesSelecionados)
        {
            foreach(Filme filme in filmesSelecionados)
            {
                var filmeLocado = new Dictionary<string, string> {
                                                 {"Id",filme.Id.ToString() },
                                                 {"Filme",filme.Nome },
                                                 {"Genêro",filme.Genero.Nome },
                                                 {"Categoria",filme.Categoria.Nome },
                                                 {"Valor da Diária",filme.Categoria.ValorDiaria.ToString() },
                                                 {"Total das Diárias",(filme.Categoria.ValorDiaria * (decimal)tempoDeLocacao.TotalDays).ToString() },
                                               };

                bool existe = false;
                foreach(var item in filmesLocados)
                {
                    if (item["Id"].Contains(filmeLocado["Id"]))
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    filmesLocados.Add(filmeLocado);
                }
            }
            
            dgvLocados.Rows.Clear();
            foreach(var item in filmesLocados)
            {
                dgvLocados.Rows.Add(item.Values.ToArray());
            }
            
            dgvLocados.Refresh();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            btnFinalizaLocacao.Enabled = true;
            AtualizaTempoDeLocacao();
            AtualizaValorDasDiarias();
            AtualizaValorTotal();

        }

        private void AtualizaValorTotal()
        {
            valorTotal = 0;
            foreach(var filme in filmesLocados)
            {
                valorTotal += decimal.Parse(filme["Total das Diárias"]);
            }
            txtValorTotal.Text = valorTotal.ToString();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFilmes.DataSource = filmeDAL.GetFilmes().Where(filme => filme.Categoria.Nome == cbCategoria.SelectedItem.ToString()).ToList();
            dgvFilmes.Refresh();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {  
            dgvFilmes.DataSource = filmeDAL.GetFilmes().Where(filme => filme.Categoria.Nome == cbCategoria.SelectedItem.ToString() && filme.Genero.Nome == cbGenero.SelectedItem.ToString()).ToList();
            dgvFilmes.Refresh();
        }

        private void maskedTxtCPF_TextChanged(object sender, EventArgs e)
        {
            maskedTxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTxtCPF.Text;
            cbCliente.DataSource = clienteDAL.ObterClientePorCPF(cpf);
            cbCliente.Refresh();
            //cbCliente.Text = null;
            //MessageBox.Show("Teste");
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.Focused)
            {
                maskedTxtCPF.Text = ((Cliente)cbCliente.SelectedItem).CPF;
            }
        }

        private void txtNomeFilme_TextChanged(object sender, EventArgs e)
        {
            dgvFilmes.DataSource = ((List<Filme>)dgvFilmes.DataSource).Where(filme => filme.Nome.Contains(txtNomeFilme.Text)).ToList();
        }

        private void btnFinalizaLocacao_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cbCliente.SelectedItem;
            Locacao locacao = new Locacao
            {
                Id = (int)locacaoDAL.GetNextId(),
                DataLocacao = dtpLocacao.Value.Date,
                DataDevolucao = dtpDevolucao.Value.Date,
                FilmesLocados = filmesLocados,
                ValorTotal = valorTotal,
                Cliente = cliente,
            };
            locacaoDAL.AdicionaLocacao(locacao);
            MessageBox.Show($"Locação realizada\nPara o Cliente:{locacao.Cliente.Nome}\nValor Total:R${valorTotal}");
            AtualizaStatusDeLocacao();
            dgvLocados.Rows.Clear(); //limpa a tabela de locação
            filmesLocados.Clear(); //Limpa a lista de filmes locados
            AtualizaValorTotal();
            
        }

        private void AtualizaStatusDeLocacao()
        {
            foreach(var filme in filmesLocados)
            {
                var objFilme = filmeDAL.ObterFilme(Convert.ToInt32(filme["Id"]));
                objFilme.Locado = true;
                filmeDAL.AtualizarFilme(objFilme);
            }
        }

        private void AtualizaValorDasDiarias()
        {
            foreach (var filme in filmesLocados)
            {
                filme["Total das Diárias"] = (decimal.Parse(filme["Valor da Diária"]) * (decimal)tempoDeLocacao.TotalDays).ToString();
            }
        }
        private void AtualizaTempoDeLocacao()
        {
            var diaLocacao = dtpLocacao.Value.Date;
            var diaDevolucao = dtpDevolucao.Value.Date;
            tempoDeLocacao = TimeSpan.FromDays(diaDevolucao.Subtract(diaLocacao).Days);
        }

        private void dtpLocacao_ValueChanged(object sender, EventArgs e)
        {
            AtualizaTempoDeLocacao();
            AtualizaValorDasDiarias();
        }
    }
}
