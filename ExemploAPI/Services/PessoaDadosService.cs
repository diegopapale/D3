using ExemploAPI.Data;
using ExemploAPI.Models;
using System.Collections.Generic;


namespace ExemploAPI.Services
{
    public class PessoaDadosService
    {
        // entity contem dados para inserir, regra de negocio
        public bool Add(PessoaDados entity)
        {
            if (!string.IsNullOrEmpty(entity.Nome))
            {
                return new PessoaDadosRepository().Add(entity);
            }
            else
            {
                return false;
            }
        }

        // retorna uma lista com todos os produtos do banco
        public List<PessoaDados> Get()
        {
            // regra de negocio
            return new PessoaDadosRepository().Get();
        }


        public bool Delete(PessoaDados entity)
        {
            // regra de negocio
            if (entity.IdDados > 0)
            {
                return new PessoaDadosRepository().Delete(entity);
            }
            else
            {
                return false;
            }
        }

        public bool Put(PessoaDados entity)
        {
            // regra de negocio
            if (entity.IdDados > 0)
            {
                return new PessoaDadosRepository().Put(entity);
            }
            else
            {
                return false;
            }
        }
    }

}