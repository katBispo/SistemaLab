using System;
using SistemaLab.Model.enums;

namespace SistemaLab.Model
{
    public class Reagente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Fabricante { get; set; }
        public string Lote { get; set; }

        public Usuario Usuario { get; set; }
        public CategoriaReagente CategoriaReagente { get; set; }

        public Caracteristica Caracteristicas { get; set; }
        public TipoReagente Tipo { get; set; }
        public EstadoFisico Estado { get; set; } // Nova propriedade



        public Reagente(int id, string nome, DateTime dataVencimento, DateTime dataCadastro, string fabricante, string lote, Caracteristica caracteristicas, TipoReagente tipo, EstadoFisico estado)
        {
            Id = id;
            Nome = nome;
            DataVencimento = dataVencimento;
            DataCadastro = dataCadastro;
            Fabricante = fabricante;
            Lote = lote;
            Caracteristicas = caracteristicas;
            Tipo = tipo;
            Estado = estado;


        }

        public Reagente() { }
    }
}
