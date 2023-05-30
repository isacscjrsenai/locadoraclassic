using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LocadoraClassic.VO;
using MySqlX.XDevAPI;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {
        public void InserirCliente(Cliente cliente)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            //MySqlCommand
            string query = "INSERT IGNORE INTO cliente(nome,cpf,rg,tel,endereco)values(@nome,@cpf,@rg,@tel,@endereco)";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.CPF));
            cmd.Parameters.Add(new MySqlParameter("@rg", cliente.RG));
            cmd.Parameters.Add(new MySqlParameter("@tel", cliente.Tel));
            cmd.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public List<Cliente> ObterClientes()
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM cliente";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.Tel = reader["tel"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                clientes.Add(cliente);
            }
            reader.Close();
            conn.Instance.Close();
            return clientes;
        }
        public List<Cliente> ObterClientePorCPF(string cpf)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * FROM cliente WHERE cpf like '{cpf}%'";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.Tel = reader["tel"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                clientes.Add(cliente);
            }
            reader.Close();
            conn.Instance.Close();
            return clientes;
        }
        public List<Cliente> ObterClientePorNome(string nome)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * FROM cliente WHERE nome=@nome'";
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.Tel = reader["tel"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                clientes.Add(cliente);
            }
            reader.Close();
            conn.Instance.Close();
            return clientes;
        }


        public void DeletarCliente(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "DELETE FROM cliente WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public void AtualizarCliente(Cliente cliente)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "UPDATE cliente SET nome=@nome,cpf=@cpf,rg=@rg,tel=@tel,endereco=@endereco WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.CPF));
            cmd.Parameters.Add(new MySqlParameter("@rg", cliente.RG));
            cmd.Parameters.Add(new MySqlParameter("@tel", cliente.Tel));
            cmd.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            cmd.Parameters.Add(new MySqlParameter("@id", cliente.Id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();

        }
    }
}
