using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    public class PessoaTelefoneModel
    {
        public int Id { get; set; }
        public string TelefonePessoal { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneRecado { get; set; }
        public int IdPessoa { get; set; }

        public PessoaTelefoneModel(string telefonePessoal = "", string telefoneResidencial = "", string telefoneRecado = "", int idPessoa = 0, int id = 0)
        {
            this.Id = id;
            this.TelefonePessoal = telefonePessoal;
            this.TelefoneResidencial = telefoneResidencial;
            this.TelefoneRecado = telefoneRecado;
            this.IdPessoa = idPessoa;
        }
    }
}