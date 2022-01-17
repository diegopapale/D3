using ExemploAPI.Data;
using ExemploAPI.Models;
using System.Collections.Generic;

namespace ExemploAPI.Services
{
    public class PessoaTelefoneService
    {
        // entity dados para inserir
        public bool Add(PessoaTelefone entity)
        {
            if (entity.IdPessoa > 0)
            {
                return new PessoaTelefoneRepository().Add(entity);
            }
            else             
            {
                return false;
            }
        }

        // retorna uma lista com todos os produtos do banco
        public List<PessoaTelefone> Get()
        {
            return new PessoaTelefoneRepository().Get();
        }

        // excluir
        public bool Delete(PessoaTelefone entity)
        {
            if (entity.Id > 0)
            {
                return new PessoaTelefoneRepository().Delete(entity);
            }
            else
            {
                return false;
            }
        }

        // alterar
        public bool Put(PessoaTelefone entity)
        {
            if (entity.Id > 0)
            {
                return new PessoaTelefoneRepository().Put(entity);
            }
            else
            {
                return false;
            }
        }
    }
}