using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploAPI.Models
{
    public class PessoaTelefone
    {
        public int Id { get; set; }
        public string TelefonePessoal { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneRecado { get; set; }
        public int IdPessoa { get; set; }

        public PessoaTelefone(string telefonePessoal, string telefoneResidencial, string telefoneRecado, int idPessoa, int id = 0)
        {
            this.Id = id;
            this.TelefonePessoal = telefonePessoal;
            this.TelefoneResidencial = telefoneResidencial;
            this.TelefoneRecado = telefoneRecado;
            this.IdPessoa = idPessoa;
        }
    }
}