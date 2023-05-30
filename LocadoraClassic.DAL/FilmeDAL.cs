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
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            //MySqlCommand
            string query = "INSERT IGNORE INTO filme(nome,duracao,sinopse,locado,id_genero,id_categoria)values(@nome,@duracao,@sinopse,@locado,@id_genero,@id_categoria)";
            MySqlCommand cmd = conn.Instance.CreateCommand();
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
            conn.Instance.Close();
        }
        public List<Filme> ObterFilmes()
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM filme";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Filme> filmes = new List<Filme>();
            while (reader.Read())
            {
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(reader["id"]);
                filme.Nome = reader["nome"].ToString();
                filme.Duracao = Convert.ToInt32(reader["duracao"]);
                filme.Sinopse = reader["sinopse"].ToString();
                filme.Locado = (bool)reader["locado"];
                filme.Genero = new GeneroDAL().ObterGenero(Convert.ToInt32(reader["id_genero"]));
                filme.Categoria = new CategoriaDAL().ObterCategoria(Convert.ToInt32(reader["id_categoria"]));
                filmes.Add(filme);
            }
            reader.Close();
            conn.Instance.Close();
            return filmes;
        }
        public List<Filme> GetFilmes()
        {

            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT filme.id as codigo,filme.nome as filme, filme.sinopse, filme.locado, filme.duracao, categoria.nome AS categoria, categoria.valor_diaria AS diaria, genero.nome AS genero\r\nFROM filme\r\nINNER JOIN categoria ON filme.id_categoria = categoria.id\r\nINNER JOIN genero ON filme.id_genero = genero.id;";
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Filme> filmes = new List<Filme>();
            while (reader.Read())
            {
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(reader["codigo"]);
                filme.Nome = reader["filme"].ToString();
                filme.Duracao = Convert.ToInt32(reader["duracao"]);
                filme.Sinopse = reader["sinopse"].ToString();
                filme.Locado = Convert.ToBoolean(reader["locado"]);
                filme.Genero = new Genero();
                filme.Genero.Nome = reader["genero"].ToString();
                filme.Categoria = new Categoria();
                filme.Categoria.Nome = reader["categoria"].ToString();
                filme.Categoria.ValorDiaria = Convert.ToDecimal(reader["diaria"]);
                filmes.Add(filme);
            }
            reader.Close();
            conn.Instance.Close();
            return filmes;


        }
        public Filme ObterFilme(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM filme WHERE id=@id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            //Executa o comando e obter o resultado
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(reader["id"]);
            filme.Nome = reader["nome"].ToString();
            filme.Duracao = Convert.ToInt32(reader["duracao"]);
            filme.Sinopse = reader["sinopse"].ToString();
            filme.Locado = (bool)reader["locado"];
            filme.Genero = new GeneroDAL().ObterGenero(Convert.ToInt32(reader["id_genero"]));
            filme.Categoria = new CategoriaDAL().ObterCategoria(Convert.ToInt32(reader["id_categoria"]));
            return filme;
        }


        public void DeletarFilme(int id)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "DELETE FROM filme WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
        public void AtualizarFilme(Filme filme)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "UPDATE filme SET nome=@nome,duracao=@duracao,sinopse=@sinopse,locado=@locado,id_genero=@id_genero,id_categoria=@id_categoria WHERE id=@id";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.Add(new MySqlParameter("@duracao", filme.Duracao));
            cmd.Parameters.Add(new MySqlParameter("@nome", filme.Nome));
            cmd.Parameters.Add(new MySqlParameter("@sinopse", filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@locado", filme.Locado));
            cmd.Parameters.Add(new MySqlParameter("@id_genero", filme.Genero.Id));
            cmd.Parameters.Add(new MySqlParameter("@id_categoria", filme.Sinopse));
            cmd.Parameters.Add(new MySqlParameter("@id_categoria", filme.Id));
            cmd.ExecuteNonQuery();
            conn.Instance.Close();
        }
    }
}
