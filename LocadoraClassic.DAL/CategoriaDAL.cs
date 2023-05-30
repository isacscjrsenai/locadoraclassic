using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {
        public void InserirCategoria(Categoria categoria)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            //MySqlCommand
            string query = "INSERT IGNORE INTO categoria(nome,valor_diaria)values(@nome,@valor_diaria)";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", categoria.Nome));
            cmd.Parameters.Add(new MySqlParameter("@valor_diaria", categoria.ValorDiaria.ToString()));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public List<Categoria> ObterCategorias()
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM categoria";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = Convert.ToInt32(reader["id"]);
                categoria.Nome = reader["nome"].ToString();
                categoria.ValorDiaria = Convert.ToInt16(reader["valor_diaria"]);
                categorias.Add(categoria);
            }
            reader.Close();
            conn.Instance.Close();
            return categorias;
        }
        public Categoria ObterCategoria(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM categoria WHERE id=@id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Categoria categoria = new Categoria();
            categoria.Id = Convert.ToInt32(reader["id"]);
            categoria.Nome = reader["nome"].ToString();
            categoria.ValorDiaria = Convert.ToInt32(reader["valor_diaria"]);
            reader.Close();
            conn.Instance.Close();
            return categoria;
        }

        public Categoria ObterCategoria(string nome)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM categoria WHERE nome=@nome";
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Categoria categoria = new Categoria();
            categoria.Id = Convert.ToInt32(reader["id"]);
            categoria.Nome = reader["nome"].ToString();
            categoria.ValorDiaria = Convert.ToInt32(reader["valor_diaria"]);
            reader.Close();
            conn.Instance.Close();
            return categoria;
        }
        public void DeletarCategoria(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "DELETE FROM categoria WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "UPDATE categoria SET nome=@nome, valor_diaria=@valor_diaria WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", categoria.Nome));
            cmd.Parameters.Add(new MySqlParameter("valor_diaria",categoria.ValorDiaria));
            cmd.Parameters.Add(new MySqlParameter("@id", categoria.Id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
    }
}
