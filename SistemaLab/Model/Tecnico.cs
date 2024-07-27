using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Tecnico : Usuario
    {
        public string registroProfissional { get;  set; }

        public Tecnico(int id, string nome, string cPF, DateTime dataNascimento, string telefone, string email,string registroProfissional) : base(id, nome, cPF, dataNascimento, telefone, email)
        {
            this.registroProfissional = registroProfissional;
        }
        public Tecnico() { }

        public string RegistroProfissional { get => registroProfissional; set => registroProfissional = value; }
    }
}
