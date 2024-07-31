using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLab.Model
{
    public class Usuario
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string CPF { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string Telefone { get;  set; }
        public string Email { get;  set; }
        public List<Reagente> Reagentes { get;  set; }
        public List<Residuo> Residuos { get;  set; }


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
