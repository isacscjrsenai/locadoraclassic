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
    public partial class FrmCadastroCliente : Form
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        public FrmCadastroCliente()
        {
            InitializeComponent();
            dvgCliente.DataSource = clienteDAL.ObterClientes().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtNomeCliente.Text;
            var rg = maskedTxtRGCliente.Text;
            var cpf = maskedTxtCPFCliente.Text;
            var tel = maskedTxtTelefoneCliente.Text;
            var endereco = txtEnderecoCliente.Text;
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.RG = rg;
            cliente.CPF = cpf;
            cliente.Tel = tel;
            cliente.Endereco = endereco;
            clienteDAL.InserirCliente(cliente);
            CarregaGrid();
            txtNomeCliente.Text = "";
            maskedTxtRGCliente.Text = "";
            maskedTxtCPFCliente.Text = "";
            maskedTxtTelefoneCliente.Text = "";
            txtEnderecoCliente.Text = "";
            MessageBox.Show($"Cliente {nome} inserido com sucesso", "Locadora Classic");

        }
        private void CarregaGrid()
        {
            dvgCliente.DataSource = clienteDAL.ObterClientes().ToList();
            dvgCliente.Refresh();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            List<string> clientesDeletados = new List<string>();

            if (dvgCliente.SelectedCells.Count >= 0)
            {
                //seleciona todas as linhas das celulas selecionadas
                foreach (DataGridViewCell cell in dvgCliente.SelectedCells)
                {
                    DataGridViewRow row = dvgCliente.Rows[cell.RowIndex];
                    //seleciona a linha inteira
                    row.Selected = true;
                }
            }

            if (dvgCliente.SelectedRows.Count > 0)
            {
                var seletedRows = dvgCliente.SelectedRows;
                foreach (DataGridViewRow seletedRow in seletedRows)
                {
                    clienteDAL.DeletarCliente(Convert.ToInt32(seletedRow.Cells["Id"].Value.ToString()));
                    clientesDeletados.Add(seletedRow.Cells["Nome"].Value.ToString());
                }
            }
            CarregaGrid();
            MessageBox.Show($"Categoria(s): {string.Join(",", clientesDeletados)} deletada(s)");
        }

        private void dvgCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgCliente.Rows[e.RowIndex];
                //seleciona a linha inteira
                row.Selected = true;
            }
            //verifica se tem alguma linha selecionada no DataGridView
            if (dvgCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvgCliente.SelectedRows[0];
                //Obtém o "id" da célula selecionada
                var id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                var nome = row.Cells["Nome"].Value.ToString();
                var rg = row.Cells["RG"].Value.ToString();
                var cpf = row.Cells["CPF"].Value.ToString();
                var tel = row.Cells["Tel"].Value.ToString();
                var endereco = row.Cells["Endereco"].Value.ToString();
                var cliente = new Cliente(id, nome,cpf,rg,tel,endereco);
                clienteDAL.AtualizarCliente(cliente);
            }
            CarregaGrid();
        }
    }
}
