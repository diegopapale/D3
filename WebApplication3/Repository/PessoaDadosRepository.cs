using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Model;

namespace WebApplication3.Repository
{
    public class PessoaDadosRepository
    {
        public List<PessoaDadosModel> Pesquisar()
        {
            try
            {
                var client = new RestClient("https://localhost:44325/api/PessoaDados");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);
                var _lista = JsonConvert.DeserializeObject<List<PessoaDadosModel>>(response.Content);
                return _lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public bool Incluir(PessoaDadosModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44325/api/PessoaDados");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.POST);

                if (entity.Nome == null)
                    return false;

                if (entity.DataNascimento == null)
                    return false;

                //entity.DataNascimento = new DateTime();

                var _json = JsonConvert.SerializeObject(entity);

                request.AddParameter("application/json; charset=utf-8", _json, ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(PessoaDadosModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaDados");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.DELETE);

                entity.Nome = "";

                var _json = JsonConvert.SerializeObject(entity);

                request.AddParameter("application/json; charset=utf-8", _json, ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public PessoaDadosModel PesquisarPorId(PessoaDadosModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaDados");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);
                var _lista = JsonConvert.DeserializeObject<List<PessoaDadosModel>>(response.Content);
                return _lista.Where(p => p.IdDados == entity.IdDados).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Atualizar(PessoaDadosModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaDados");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.PUT);

                if (entity.Nome == null)
                    return false;

                if (entity.DataNascimento == null)
                    return false;

                var _json = JsonConvert.SerializeObject(entity);

                request.AddParameter("application/json; charset=utf-8", _json, ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}