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
    }
}
