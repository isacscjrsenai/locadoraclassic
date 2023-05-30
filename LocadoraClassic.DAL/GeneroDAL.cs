using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class GeneroDAL
    {
        
        public void InserirGenero(Genero genero)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            //MySqlCommand
            string query = "INSERT IGNORE INTO genero(nome)values(@nome)";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", genero.Nome));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public List<Genero> ObterGeneros()
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM genero";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            while (reader.Read())
            {
                Genero genero = new Genero();
                genero.Id = Convert.ToInt32(reader["id"]);
                genero.Nome = reader["nome"].ToString();
                generos.Add(genero);
            }
            reader.Close();
            conn.Instance.Close ();
            return generos;
        }
        public Genero ObterGenero(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM genero WHERE id=@id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            reader.Read();
            Genero genero = new Genero();
            genero.Id = Convert.ToInt32(reader["id"]);
            genero.Nome = reader["nome"].ToString();
            reader.Close();
            conn.Instance.Close();
            return genero;
        }
        public Genero ObterGenero(string nome)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM genero WHERE nome=@nome";
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            reader.Read();
            Genero genero = new Genero();
            genero.Id = Convert.ToInt32(reader["id"]);
            genero.Nome = reader["nome"].ToString();
            reader.Close();
            conn.Instance.Close();
            return genero;
        }

        public void DeletarGenero(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "DELETE FROM genero WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public void AtualizarGenero(Genero genero)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "UPDATE genero SET nome=@nome WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", genero.Nome));
            cmd.Parameters.Add(new MySqlParameter("@id", genero.Id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
    }
   
}
//Faz um CRUD ai?
//INSERT 
//DELETE
//UPDATE
//SELECT