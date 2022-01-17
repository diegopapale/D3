using ExemploAPI.Models;
using ExemploAPI.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace ExemploAPI.Controllers
{
    public class PessoaDadosController : ApiController
    {

        public List<PessoaDados> Get() // consulta
        {
            return new PessoaDadosService().Get();
        }

        //adicionar
        public void Post([FromBody] PessoaDados entity) // inserir
        {
            new PessoaDadosService().Add(entity);
        }

        //deletar
        public void Delete([FromBody] PessoaDados entity) // excluir
        {
            new PessoaDadosService().Delete(entity);
        }

        public void Put([FromBody] PessoaDados entity) // alteracao
        {
            new PessoaDadosService().Put(entity);
        }

    }
}