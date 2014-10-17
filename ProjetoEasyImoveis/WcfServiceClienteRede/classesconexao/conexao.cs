using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesconexao
{
    class conexao
    {
        public SqlConnection sqlconn;
        String ConnectionStringSqlServer = "Data Source=localhost; Initial Catalog= easyimovel; UId=mimmo;Password=codex632;";



        public  SqlConnection abrirconexao()
        {
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(ConnectionStringSqlServer);
                sqlconn.Open();
                
            }
            return sqlconn;
        }
       

        public void fecharConexao()
        {
            sqlconn.Close();
            sqlconn.Dispose();
        } 

    }
}
