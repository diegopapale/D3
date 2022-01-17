using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication3.Data
{
    public class Conexao
    {
        public SqlConnection Carregar()
        {
            try
            {

                string connetionString = @"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=TestePratico;Data Source=BRUNO";
                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                return conn;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}