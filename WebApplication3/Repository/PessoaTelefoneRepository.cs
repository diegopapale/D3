using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Model;

namespace WebApplication3.Repository
{
    public class PessoaTelefoneRepository
    {
        public List<PessoaTelefoneModel> Pesquisar()
        {
            try
            {
                var client = new RestClient("https://localhost:44325/api/PessoaTelefone");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);
                var _lista = JsonConvert.DeserializeObject<List<PessoaTelefoneModel>>(response.Content);
                return _lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public bool Incluir(PessoaTelefoneModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44325/api/PessoaTelefone");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.POST);

                if (entity.TelefonePessoal == null)
                    return false;

                if (entity.TelefoneRecado == null)
                    return false;
                if (entity.TelefoneResidencial == null)
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

        public bool Delete(PessoaTelefoneModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaTelefone");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.DELETE);

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
        public PessoaTelefoneModel PesquisarPorId(PessoaTelefoneModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaTelefone");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);
                var _lista = JsonConvert.DeserializeObject<List<PessoaTelefoneModel>>(response.Content);
                return _lista.Where(p => p.Id == entity.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Atualizar(PessoaTelefoneModel entity)
        {
            try
            {
                var client = new RestClient("https://localhost:44399/api/PessoaDados");
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.PUT);

                if (entity.TelefonePessoal == null)
                    return false;

                if (entity.TelefoneRecado == null)
                    return false;
                if (entity.TelefoneResidencial == null)
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