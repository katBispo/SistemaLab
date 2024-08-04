using System;
using SistemaLab.Model.enums;

namespace SistemaLab.Model
{
    public class Residuo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataGeracao { get; set; }
        public TipoResiduo Tipo { get; set; }
        public Usuario Usuario { get; set; }

        public Residuo(int id, string nome, DateTime dataGeracao, TipoResiduo tipo)
        {
            Id = id;
            Nome = nome;
            DataGeracao = dataGeracao;
            Tipo = tipo;
        }

        public Residuo() { }
    }
}
