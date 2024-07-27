using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLab.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public Usuario(int id, string nome, string cpf, DateTime dataNascimento, string telefone, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
            this.Email = email;
        }
        public Usuario() { }
    }
}
