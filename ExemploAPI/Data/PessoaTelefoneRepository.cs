using ExemploAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExemploAPI.Data
{
    public class PessoaTelefoneRepository
    {
        public bool Add(PessoaTelefone entity)
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"INSERT INTO PESSOATELEFONE(telefonePessoal, telefoneRecado, telefoneResidencial, idPessoa)
                    VALUES('{entity.TelefonePessoal}','{entity.TelefoneRecado}','{entity.TelefoneResidencial}', {entity.IdPessoa})", _conexao);

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

        public List<PessoaTelefone> Get()
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand comando = new SqlCommand($@"SELECT * FROM PESSOATELEFONE", _conexao);

            try
            {

                SqlDataReader reader = comando.ExecuteReader(); // retorna alguma coisa / lista

                List<PessoaTelefone> values = new List<PessoaTelefone>();

                while (reader.Read())
                {
                    values.Add(new PessoaTelefone(
                        reader["TelefonePessoal"].ToString(),
                        reader["TelefoneResidencial"].ToString(),
                        reader["TelefoneRecado"].ToString(),
                        int.Parse(reader["IdPessoa"].ToString()),
                        int.Parse(reader["Id"].ToString())
                        ));
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

        public bool Delete(PessoaTelefone entity) // esperando como parametro >> PessoaTelefone
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"DELETE FROM PESSOATELEFONE 
                   WHERE Id = {entity.Id}", _conexao);

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

        public bool Put(PessoaTelefone entity)
        {
            var _conexao = new Conexao().CarregarSQLServer();

            SqlCommand conn = new SqlCommand(
                $@"UPDATE PESSOATELEFONE SET TelefonePessoal='{entity.TelefonePessoal}',TelefoneResidencial='{entity.TelefoneRecado}',TelefoneRecado='{entity.TelefoneResidencial}'
                   WHERE id = {entity.Id} ", _conexao);

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