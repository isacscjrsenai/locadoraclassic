using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LocadoraClassic.VO;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme filme)
        {
            Connection.Instance.Open();
            //MySqlCommand
            string query = "INSERT IGNORE INTO categoria(nome,duracao,sinopse,locado,id_genero,id_categoria)values(@nome,@duracao,@sinopse,@locado,@id_genero,@id_categoria)";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@nome", filme.Nome));
            cmd.Parameters.Add(new MySqlParameter("@duracao", filme.Duracao));
            cmd.Parameters.Add(new MySqlParameter("@sinopse",filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@locado", filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@id_genero", filme.Genero.Id));
            cmd.Parameters.Add(new MySqlParameter("@id_categoria", filme.Categoria.Id));
            cmd.ExecuteNonQuery();
            Connection.Instance.Close();
        }
        public List<Filme> ObterFilmes()
        {
            Connection.Instance.Open();
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM filme";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Filme> filmes = new List<Filme>();
            while (reader.Read())
            {
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(reader["id"]);
                filme.Duracao = Convert.ToInt32(reader["duracao"]);
                filme.Sinopse = reader["sinopse"].ToString();
                filme.Locado = (bool)reader["locado"];
                filme.Genero = new GeneroDAL().ObterGenero(Convert.ToInt32(reader["id_genero"]));
                filme.Categoria = new CategoriaDAL().ObterCategoria(Convert.ToInt32(reader["id_categoria"]));
                filmes.Add(filme);
            }
            reader.Close();
            Connection.Instance.Close();
            return filmes;
        }
        public Filme ObterFilme(string nome)
        {
            Connection.Instance.Open();
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM filme WHERE nome=@nome";
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(reader["id"]);
            filme.Duracao = Convert.ToInt32(reader["duracao"]);
            filme.Sinopse = reader["sinopse"].ToString();
            filme.Locado = (bool)reader["locado"];
            filme.Genero = new GeneroDAL().ObterGenero(Convert.ToInt32(reader["id_genero"]));
            filme.Categoria = new CategoriaDAL().ObterCategoria(Convert.ToInt32(reader["id_categoria"]));
            return filme;
        }


        public void DeletarFilme(Filme filme)
        {
            Connection.Instance.Open();
            string query = "DELETE FROM filme WHERE id=@id";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", filme.Id));
            cmd.ExecuteNonQuery();
            Connection.Instance.Close();
        }
        public void AtualizarFilme(Filme filme, int id)
        {
            Connection.Instance.Open();
            string query = "UPDATE filme SET nome=@nome,duracao=@duracao,sinopse=@sinopse,locado=@locado,id_genero=@id_genero,id_categoria=@id_categoria WHERE id=@id";
            MySqlCommand cmd = Connection.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@duracao", filme.Duracao));
            cmd.Parameters.Add(new MySqlParameter("@nome", filme.Nome));
            cmd.Parameters.Add(new MySqlParameter("@sinopse", filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@locado", filme.Locado));
            cmd.Parameters.Add(new MySqlParameter("@id_genero", filme.Genero.Id));
            cmd.Parameters.Add(new MySqlParameter("@id_categoria", filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@id_categoria", id));
            cmd.ExecuteNonQuery();
            Connection.Instance.Close();
        }
    }
}
