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
            Connection.Instance.Open();
            //MySqlCommand
            string query = "INSERT IGNORE INTO cliente(nome,cpf,rg,tel,endereco)values(@nome,@cpf,@rg,@tel,@endereco)";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
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
            Connection.Instance.Close();
        }
        public List<Cliente> ObterClientes()
        {
            Connection.Instance.Open();
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM cliente";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.Tel = reader["tel"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                clientes.Add(cliente);
            }
            reader.Close();
            Connection.Instance.Close();
            return clientes;
        }
        public List<Cliente> ObterCliente(string nome)
        {
            Connection.Instance.Open();
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM cliente WHERE nome=@nome";
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.CPF = reader["cpf"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.Tel = reader["tel"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                clientes.Add(cliente);
            }
            reader.Close();
            Connection.Instance.Close();
            return clientes;
        }


        public void DeletarCliente(int id)
        {
            Connection.Instance.Open();
            string query = "DELETE FROM cliente WHERE id=@id";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            Connection.Instance.Close();
        }
        public void AtualizarCliente(Cliente cliente)
        {
            Connection.Instance.Open();
            string query = "UPDATE cliente SET nome=@nome,cpf=@cpf,rg=@rg,tel=@tel,endereco=@endereco WHERE id=@id";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.CPF));
            cmd.Parameters.Add(new MySqlParameter("@rg", cliente.RG));
            cmd.Parameters.Add(new MySqlParameter("@tel", cliente.Tel));
            cmd.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            cmd.Parameters.Add(new MySqlParameter("@id", cliente.Id));
            cmd.ExecuteNonQuery();
            Connection.Instance.Close();

        }
    }
}
