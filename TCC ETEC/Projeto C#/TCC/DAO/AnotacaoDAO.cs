using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.model;

namespace TCC.DAO
{
    class AnotacaoDAO
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dtAdapter;

        public void anotacao(Anotacao anot)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "INSERT INTO ANOTACAO (ID_CONSULTA, ANOTACAO) VALUES(@ID_CONSULTA, @ANOTACAO)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@ID_CONSULTA", anot.Id_consulta));
                cmd.Parameters.Add(new SqlParameter("@ANOTACAO", anot.Apontamento));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao Salva a Anotação.\nErro: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void alterar(Anotacao anot, int idCons)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "UPDATE ANOTACAO SET ANOTACAO=@ANOTACAO WHERE ID_CONSULTA=" + idCons + "";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ANOTACAO", anot.Apontamento));
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao Alterar os Dados.\nErro: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable consulta(int idCons)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT * FROM ANOTACAO WHERE ID_CONSULTA =" + idCons + "";
                DataTable dt_cons = new DataTable();
                dtAdapter = new SqlDataAdapter(sql, conn);
                dtAdapter.Fill(dt_cons);
                return dt_cons;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Falha na Leitura dos Dados.\nErro: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
