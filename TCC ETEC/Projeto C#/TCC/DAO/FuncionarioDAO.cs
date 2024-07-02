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
    class FuncionarioDAO
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dtAdapter;

        public void inserir(Funcionario func)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                String sql = "INSERT INTO FUNCIONARIO (NOME, SEXO, SALARIO, RG, CPF, CEP, RUA, COMPLEMENTO, CIDADE, UF, DTNASC, DTCAD, CARGO, CRP, TELEFONE, CELULAR, EMAIL, USUARIO, SENHA, HENTRADA, HSAIDA, OBSERVACAO ) VALUES(@NOME, @SEXO, @SALARIO, @RG, @CPF, @CEP, @RUA, @COMPLEMENTO, @CIDADE, @UF, @DTNASC, @DTCAD, @CARGO, @CRP, @TELEFONE, @CELULAR, @EMAIL, @USUARIO, @SENHA, @HENTRADA, @HSAIDA, @OBSERVACAO )";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@NOME", func.Nome));
                cmd.Parameters.Add(new SqlParameter("@SEXO", func.Sexo));
                cmd.Parameters.Add(new SqlParameter("@SALARIO", func.Salario));
                cmd.Parameters.Add(new SqlParameter("@RG", func.Rg));
                cmd.Parameters.Add(new SqlParameter("@CPF", func.Cpf));
                cmd.Parameters.Add(new SqlParameter("@CEP", func.Cep));
                cmd.Parameters.Add(new SqlParameter("@RUA", func.Rua));
                cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", func.Complemento));
                cmd.Parameters.Add(new SqlParameter("@CIDADE", func.Cidade));
                cmd.Parameters.Add(new SqlParameter("@UF", func.Uf));
                cmd.Parameters.Add(new SqlParameter("@DTNASC", func.Dtnas));
                cmd.Parameters.Add(new SqlParameter("@DTCAD", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@CARGO", func.Cargo));
                cmd.Parameters.Add(new SqlParameter("@CRP", func.Crp));
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", func.Telefone));
                cmd.Parameters.Add(new SqlParameter("@CELULAR", func.Celular));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", func.Email));
                cmd.Parameters.Add(new SqlParameter("@USUARIO", func.Usuario));
                cmd.Parameters.Add(new SqlParameter("@SENHA", func.Senha));
                cmd.Parameters.Add(new SqlParameter("@HENTRADA", func.Hentrada));
                cmd.Parameters.Add(new SqlParameter("@HSAIDA", func.Hsaida));
                cmd.Parameters.Add(new SqlParameter("@OBSERVACAO", func.Observacao));

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
                String sql = "SELECT * FROM FUNCIONARIO WHERE USUARIO = '" + usu + "' AND SENHA = '" + senha + "'";
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
   public void alterar(Funcionario func, int idFunc)
         {
             conn = new ConnectionFactory().getConnection();

             try
             {
                 String sql = "UPDATE FUNCIONARIO SET NOME=@NOME, SEXO=@SEXO, SALARIO=@SALARIO, RG=@RG, CPF=@CPF, CEP=@CEP, RUA=@RUA, COMPLEMENTO=@COMPLEMENTO, CIDADE=@CIDADE, UF=@UF, DTNASC=@DTNASC, CARGO=@CARGO, CRP=@CRP, TELEFONE=@TELEFONE, CELULAR=@CELULAR, EMAIL=@EMAIL, USUARIO=@USUARIO, SENHA=@SENHA, HENTRADA=@HENTRADA, HSAIDA=@HSAIDA, OBSERVACAO=@OBSERVACAO WHERE ID=" + idFunc + "";
                 cmd = conn.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.Parameters.Add(new SqlParameter("@NOME", func.Nome));
                 cmd.Parameters.Add(new SqlParameter("@SEXO", func.Sexo));
                 cmd.Parameters.Add(new SqlParameter("@SALARIO", func.Salario));
                 cmd.Parameters.Add(new SqlParameter("@RG", func.Rg));
                 cmd.Parameters.Add(new SqlParameter("@CPF", func.Cpf));
                 cmd.Parameters.Add(new SqlParameter("@CEP", func.Cep));
                 cmd.Parameters.Add(new SqlParameter("@RUA", func.Rua));
                 cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", func.Complemento));
                 cmd.Parameters.Add(new SqlParameter("@CIDADE", func.Cidade));
                 cmd.Parameters.Add(new SqlParameter("@UF", func.Uf));
                 cmd.Parameters.Add(new SqlParameter("@DTNASC", func.Dtnas));
                 cmd.Parameters.Add(new SqlParameter("@CARGO", func.Cargo));
                 cmd.Parameters.Add(new SqlParameter("@CRP", func.Crp));
                 cmd.Parameters.Add(new SqlParameter("@TELEFONE", func.Telefone));
                 cmd.Parameters.Add(new SqlParameter("@CELULAR", func.Celular));
                 cmd.Parameters.Add(new SqlParameter("@EMAIL", func.Email));
                 cmd.Parameters.Add(new SqlParameter("@USUARIO", func.Usuario));
                 cmd.Parameters.Add(new SqlParameter("@SENHA", func.Senha));
                 cmd.Parameters.Add(new SqlParameter("@HENTRADA", func.Hentrada));
                 cmd.Parameters.Add(new SqlParameter("@HSAIDA", func.Hsaida));
                 cmd.Parameters.Add(new SqlParameter("@OBSERVACAO", func.Observacao));
                 cmd.CommandText = sql;
                 cmd.ExecuteNonQuery();
                 conn.Close();
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
             String sql;
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 if (Funcionario.psicologo == false)
                 {
                     sql = "SELECT * FROM FUNCIONARIO";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 else
                 {
                     sql = "SELECT * FROM FUNCIONARIO WHERE CARGO='Psicologo'";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 DataTable dt_func = new DataTable();
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
             String sql;
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 if (Funcionario.psicologo == false)
                 {
                     sql = "SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + nome + "%'";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 else
                 {
                     sql = "SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + nome + "%' AND CARGO='Psicologo'";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 DataTable dt_func = new DataTable();
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
             String sql;
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 if (Funcionario.psicologo == false)
                 {
                     sql = "SELECT * FROM FUNCIONARIO WHERE CPF = '" + cpf + "'";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 else
                 {
                     sql = "SELECT * FROM FUNCIONARIO WHERE CPF = '" + cpf + "' AND CARGO='Psicologo'";
                     dtAdapter = new SqlDataAdapter(sql, conn);
                 }
                 DataTable dt_func = new DataTable();
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

         public DataTable buscar_cargo(string cargo)
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM FUNCIONARIO WHERE CARGO = '" + cargo + "'";
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

         public DataTable preenche(int idFunc)//Alterar
         {
             try
             {
                 conn = new ConnectionFactory().getConnection();
                 String sql = "SELECT * FROM FUNCIONARIO WHERE ID = "+idFunc;
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
                 String sql = "Delete from FUNCIONARIO where ID = @ID";//exclui os dados 
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
       
