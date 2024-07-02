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
    class PacienteDAO
    { 
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dtAdapter;

        public void inserir(Paciente pac)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "INSERT INTO PACIENTE (NOME, SEXO, RG, CPF, PAI, MAE, EC, CIDADE, UF, CEP, RUA, COMPLEMENTO, MEDICACAO, DTNASC, DTCAD, OBSERVACAO, RESPONSAVEL, TELEFONERES, TELEFONE, CELULAR, EMAIL) VALUES (@NOME, @SEXO, @RG, @CPF, @PAI, @MAE, @EC, @CIDADE, @UF, @CEP, @RUA, @COMPLEMENTO, @MEDICACAO, @DTNASC, @DTCAD, @OBSERVACAO, @RESPONSAVEL, @TELEFONERES, @TELEFONE, @CELULAR, @EMAIL)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@NOME", pac.Nome));
                cmd.Parameters.Add(new SqlParameter("@SEXO", pac.Sexo));
                cmd.Parameters.Add(new SqlParameter("@RG", pac.Rg));
                cmd.Parameters.Add(new SqlParameter("@CPF", pac.Cpf));
                cmd.Parameters.Add(new SqlParameter("@PAI", pac.Pai));
                cmd.Parameters.Add(new SqlParameter("@MAE", pac.Mae));
                cmd.Parameters.Add(new SqlParameter("@EC", pac.Ec));
                cmd.Parameters.Add(new SqlParameter("@CIDADE", pac.Cidade));
                cmd.Parameters.Add(new SqlParameter("@UF", pac.Uf));
                cmd.Parameters.Add(new SqlParameter("@CEP", pac.Cep));
                cmd.Parameters.Add(new SqlParameter("@RUA", pac.Rua));
                cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", pac.Complemento));
                cmd.Parameters.Add(new SqlParameter("@MEDICACAO", pac.Medicacao));
                cmd.Parameters.Add(new SqlParameter("@DTNASC", pac.Dtnasc));
                cmd.Parameters.Add(new SqlParameter("@DTCAD", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@OBSERVACAO", pac.Observacao));
                cmd.Parameters.Add(new SqlParameter("@RESPONSAVEL", pac.Responsavel));
                cmd.Parameters.Add(new SqlParameter("@TELEFONERES", pac.Telefoneres));
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", pac.Telefone));
                cmd.Parameters.Add(new SqlParameter("@CELULAR", pac.Celular));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", pac.Email));

                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao Inserir Dados.\nErro: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable login(string usu, string senha)
        {
            try
            {
                conn = new ConnectionFactory().getConnection();
                String sql = "SELECT * FROM PACIENTE WHERE USUARIO = '" + usu + "' AND SENHA = '" + senha + "'";
                DataTable dt_func = new DataTable();
                dtAdapter = new SqlDataAdapter(sql, conn);
                dtAdapter.Fill(dt_func);
                return dt_func;
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
   public void alterar(Paciente pac, int idPac)
         {
             conn = new ConnectionFactory().getConnection();

             try
             {
                 String sql = "UPDATE PACIENTE SET NOME=@NOME, SEXO=@SEXO, RG=@RG, CPF=@CPF,PAI=@PAI, MAE=@MAE, EC=@EC, CIDADE=@CIDADE, UF=@UF, CEP=@CEP, RUA=@RUA, COMPLEMENTO=@COMPLEMENTO, MEDICACAO=@MEDICACAO, DTNASC=@DTNASC, OBSERVACAO=@OBSERVACAO, RESPONSAVEL=@RESPONSAVEL, TELEFONERES=@TELEFONERES, TELEFONE=@TELEFONE, CELULAR=@CELULAR, EMAIL=@EMAIL WHERE ID="+ idPac +"";
                 cmd = conn.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = sql;
                 cmd.Parameters.Add(new SqlParameter("@NOME", pac.Nome));
                 cmd.Parameters.Add(new SqlParameter("@SEXO", pac.Sexo));
                 cmd.Parameters.Add(new SqlParameter("@RG", pac.Rg));
                 cmd.Parameters.Add(new SqlParameter("@CPF", pac.Cpf));
                 cmd.Parameters.Add(new SqlParameter("@PAI", pac.Pai));
                 cmd.Parameters.Add(new SqlParameter("@MAE", pac.Mae));
                 cmd.Parameters.Add(new SqlParameter("@EC", pac.Ec));
                 cmd.Parameters.Add(new SqlParameter("@CIDADE", pac.Cidade));
                 cmd.Parameters.Add(new SqlParameter("@UF", pac.Uf));
                 cmd.Parameters.Add(new SqlParameter("@CEP", pac.Cep));
                 cmd.Parameters.Add(new SqlParameter("@RUA", pac.Rua));
                 cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", pac.Complemento));
                 cmd.Parameters.Add(new SqlParameter("@MEDICACAO", pac.Medicacao));
                 cmd.Parameters.Add(new SqlParameter("@DTNASC", pac.Dtnasc));
                 cmd.Parameters.Add(new SqlParameter("@OBSERVACAO", pac.Observacao));
                 cmd.Parameters.Add(new SqlParameter("@RESPONSAVEL", pac.Responsavel));
                 cmd.Parameters.Add(new SqlParameter("@TELEFONERES", pac.Telefoneres));
                 cmd.Parameters.Add(new SqlParameter("@TELEFONE", pac.Telefone));
                 cmd.Parameters.Add(new SqlParameter("@CELULAR", pac.Celular));
                 cmd.Parameters.Add(new SqlParameter("@EMAIL", pac.Email));


                 cmd.ExecuteNonQuery();
             }
             catch (SqlException erro)
             {
                 throw new InvalidOperationException("Erro ao alterar Dados.\nErro: " + erro.Message);
             }
             finally
             {
                 conn.Close();
             }
         }

         public DataTable buscar_tudo()
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM PACIENTE";
                 DataTable dt_func = new DataTable();
                 dtAdapter = new SqlDataAdapter(sql, conn);
                 dtAdapter.Fill(dt_func);
                 return dt_func;
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

         public DataTable buscar_nome(string nome)
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM PACIENTE WHERE NOME LIKE '%"+nome+"%'";
                 DataTable dt_func = new DataTable();
                 dtAdapter = new SqlDataAdapter(sql, conn);
                 dtAdapter.Fill(dt_func);
                 return dt_func;
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

         public DataTable buscar_cpf(string cpf)
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM PACIENTE WHERE CPF = '"+cpf+"'";
                 DataTable dt_func = new DataTable();
                 dtAdapter = new SqlDataAdapter(sql, conn);
                 dtAdapter.Fill(dt_func);
                 return dt_func;
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

         public DataTable preenche(int id)//Alterar
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM PACIENTE WHERE ID = "+id;
                 DataTable dt_func = new DataTable();
                 dtAdapter = new SqlDataAdapter(sql, conn);
                 dtAdapter.Fill(dt_func);
                 return dt_func;
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


         public void excluir(Funcionario func)
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "Delete from PACIENTE where ID = @ID";//exclui os dados 
                 cmd = conn.CreateCommand();
                 cmd.CommandText = sql;
                 cmd.Parameters.Add(new SqlParameter("@ID", func.Id));
                 cmd.ExecuteNonQuery();
                 conn.Close();

             }
             catch (SqlException erro)
             {
                 throw new InvalidExpressionException("Erro ao excluir funcionário!\nErro:" + erro.Message);
             }
             finally
             {
                 conn.Close();
             }
         }




     }


 }
       
