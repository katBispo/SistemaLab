using System;
using System.Collections.Generic;

namespace SistemaLab.Model
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }  
        public List<ReservaEquipamento> Reservas { get; set; }

        public Aluno() : base()
        {
        }

        public Aluno(int id, string nome, string cpf, DateTime dataNascimento, string telefone, string email, string matricula)
            : base(id, nome, cpf, dataNascimento, telefone, email)
        {
            Matricula = matricula;
            Reservas = new List<ReservaEquipamento>();
        }
    }
}
