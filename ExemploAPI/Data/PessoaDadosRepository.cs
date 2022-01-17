using ExemploAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExemploAPI.Data
{
    public class PessoaDadosRepository // repository sqlserver
    {
        public bool Add(PessoaDados entity)
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"INSERT INTO PESSOADADOS(nome, dataNascimento)
                    VALUES('{entity.Nome}','{entity.DataNascimento}')", _conexao);

            try
            {
                conn.ExecuteReader(); // insert na tabela
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public List<PessoaDados> Get()
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand comando = new SqlCommand($@"SELECT * FROM PESSOADADOS", _conexao);

            try
            {
                
                SqlDataReader reader = comando.ExecuteReader(); // retorna alguma coisa / lista

                List<PessoaDados> values = new List<PessoaDados>();

                while (reader.Read())
                {
                    values.Add(new PessoaDados(
                        reader["Nome"].ToString(),
                        Convert.ToDateTime(reader["DataNascimento"].ToString()),
                        int.Parse(reader["IdDados"].ToString()))
                    );
                }

                return values;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool Delete(PessoaDados entity)
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"DELETE FROM PESSOADADOS 
                   WHERE IdDados = {entity.IdDados}", _conexao);

            try
            {
                conn.ExecuteReader(); // insert na tabela
                return true;
              
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool Put(PessoaDados entity)
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"UPDATE PESSOADADOS SET nome='{entity.Nome}', DataNascimento='{entity.DataNascimento}'
                   WHERE idDados = {entity.IdDados} ", _conexao);

            try
            {

                conn.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexao.Close();
            }

        }
    }
}