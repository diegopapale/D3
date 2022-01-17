using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace ExemploAPI.Data
{
    public class Conexao
    {
        public MySqlConnection Carregar() // mysql
        {
            return new MySqlConnection("server=localhost;User Id=root;database=banco_teste; password=bmc0785");
        }

        public SqlConnection CarregarSQLServer() // sqlserver
        {
            try
            {
                string connetionString =
                    @"Database=TestePratico;Server=BRUNO;User ID=sa;Password=bmc0785;";
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