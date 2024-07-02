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
    class ConsultaDAO
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dtAdapter;

        public void agendar(Consulta cons)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "INSERT INTO CONSULTA (ID_FUNCIONARIO, ID_PACIENTE, DESCRICAO, VALOR, DATA, HORARIO, STATUS) VALUES(@ID_FUNCIONARIO, @ID_PACIENTE, @DESCRICAO, @VALOR, @DATA, @HORARIO, @STATUS)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@ID_FUNCIONARIO", cons.Id_psicologo));
                cmd.Parameters.Add(new SqlParameter("@ID_PACIENTE", cons.Id_paciente));
                cmd.Parameters.Add(new SqlParameter("@DESCRICAO", cons.Descricao));
                cmd.Parameters.Add(new SqlParameter("@VALOR", cons.Valor));
                cmd.Parameters.Add(new SqlParameter("@DATA", cons.Data));
                cmd.Parameters.Add(new SqlParameter("@HORARIO", cons.Horario));
                cmd.Parameters.Add(new SqlParameter("@STATUS", Consulta.status.Pendente));
            

                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao Efetuar o Agendamento.\nErro: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void alterar(Consulta cons, int idCons)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "UPDATE CONSULTA SET ID_FUNCIONARIO=@ID_FUNCIONARIO, ID_PACIENTE=@ID_PACIENTE, DESCRICAO=@DESCRICAO, VALOR=@VALOR, DATA=@DATA, HORARIO=@HORARIO, STATUS=@STATUS WHERE ID=" + idCons + "";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID_FUNCIONARIO", cons.Id_psicologo));
                cmd.Parameters.Add(new SqlParameter("@ID_PACIENTE", cons.Id_paciente));
                cmd.Parameters.Add(new SqlParameter("@DESCRICAO", cons.Descricao));
                cmd.Parameters.Add(new SqlParameter("@VALOR", cons.Valor));
                cmd.Parameters.Add(new SqlParameter("@DATA", cons.Data));
                cmd.Parameters.Add(new SqlParameter("@HORARIO", cons.Horario));
                cmd.Parameters.Add(new SqlParameter("@STATUS", Consulta.status.Pendente));
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


        public DataTable consultar_status(int status, string dtIni, string dtFim)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT * FROM CONSULTA C INNER JOIN FUNCIONARIO F ON C.ID_FUNCIONARIO = F.ID INNER JOIN PACIENTE P ON C.ID_PACIENTE = P.ID WHERE C.STATUS =" + status + " AND C.DATA BETWEEN '" + dtIni + "' and '" + dtFim + "'";
                //String sql = "SELECT * FROM CONSULTA C INNER JOIN FUNCIONARIO F ON C.ID_FUNCIONARIO = F.ID INNER JOIN PACIENTE P ON C.ID_PACIENTE = P.ID WHERE C.STATUS =" + status + " AND WHERE C.HORARIO BETWEEN CONVERT(VARCHAR,'" + dtIni + "',101) and CONVERT(VARCHAR,'" + dtFim + "',101)";
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

        public DataTable consultar_historico(int id)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT * FROM CONSULTA C INNER JOIN FUNCIONARIO F ON C.ID_FUNCIONARIO = F.ID INNER JOIN PACIENTE P ON C.ID_PACIENTE = P.ID WHERE C.ID_PACIENTE =" + id + "";
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

        public DataTable consultar_dados(int id)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT * FROM CONSULTA WHERE ID =" + id + "";
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

        public DataTable consultar_psicologo(string data)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT ID_FUNCIONARIO, DATA, HORARIO FROM CONSULTA WHERE DATA='" + data + "'";
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

        public void status(int idCons)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "UPDATE CONSULTA SET STATUS=@STATUS WHERE ID=" + idCons + "";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@STATUS", Consulta.status.Finalizado));
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
    }
}
