using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class LocacaoDAL
    {
        public void AdicionaLocacao(Locacao locacao)
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "INSERT INTO locacao(id_locacao,data_locacao,data_devolucao,id_filme) values(@id_locacao,@data_locacao,@data_devolucao,@id_filme)";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            foreach(var filme in locacao.FilmesLocados)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new MySqlParameter("@id_locacao", locacao.Id));
                cmd.Parameters.Add(new MySqlParameter("@data_locacao", locacao.DataLocacao));
                cmd.Parameters.Add(new MySqlParameter("@data_devolucao",locacao.DataDevolucao));
                cmd.Parameters.Add(new MySqlParameter("@id_filme", Convert.ToInt32(filme["Id"])));
                cmd.ExecuteNonQuery();
            }
            conn.Instance.Close();
        }
        public int GetNextId()
        {
            Connection conn = new Connection();
            if (conn.Instance.State == System.Data.ConnectionState.Closed)
            {
                conn.Instance.Open();
            }
            string query = "SELECT IFNULL((SELECT MAX(id_locacao) FROM locacao), 0) AS ultimo_id;";
            MySqlCommand cmd = conn.Instance.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
        }
    }
}
