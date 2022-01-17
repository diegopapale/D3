using System;

namespace ExemploAPI.Models
{
    public class PessoaDados
    {
        public int IdDados { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public PessoaDados(string nome, DateTime dataNascimento, int idDados = 0)
        {
            this.IdDados = idDados;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
    }
}