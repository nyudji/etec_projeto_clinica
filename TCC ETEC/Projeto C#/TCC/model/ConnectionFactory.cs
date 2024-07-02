using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    
    class ConnectionFactory
    {
        private SqlConnection conn;

        public SqlConnection getConnection()
        {
            try
            {
                
              //conn = new SqlConnection("Data Source=172.16.48.4;Initial Catalog=jota3;User ID=jota3;Password=jota3");
               // conn = new SqlConnection("Data Source=CMC-PC; Initial Catalog=TheMentalist; Integrated Security=false; user=sa; password=enem2013");
                  //conn = new SqlConnection("Data Source=(local)\\question;Initial Catalog=TheMentalist;Integrated Security=True");
                    conn = new SqlConnection(" Data Source=LAB03-04\\ETECHAS;Initial Catalog=TheMentalist;Integrated Security=True");
                conn.Open();
                return conn;
            }
            catch (SqlException erro)
            {
                throw new NullReferenceException("Banco de Dados não Encontrado !!!" + erro.Message);
            }
        }
    }
}
