using ExemploAPI.Models;
using ExemploAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ExemploAPI.Controllers
{
    public class PessoaTelefoneController
    {
        public List<PessoaTelefone> Get() // consulta
        {
            return new PessoaTelefoneService().Get();
        }

        //adicionar
        public void Post([FromBody] PessoaTelefone entity) // inserir
        {
            new PessoaTelefoneService().Add(entity);
        }

        //deletar
        public void Delete([FromBody] PessoaTelefone entity) // excluir
        {
            new PessoaTelefoneService().Delete(entity);
        }

        public void Put([FromBody] PessoaTelefone entity) // alteracao
        {
            new PessoaTelefoneService().Put(entity);
        }
    }
}