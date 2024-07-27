using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Reagente
    {
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public DateTime dataVencimento { get; private set; }
        public DateTime dataCadastro;
        public string fabricante { get; private set; }
        public string lote { get; private set; }

        private CategoriaReagente categoriaReagente;

        public Reagente(int id, string nome, DateTime dataVencimento, DateTime dataCadastro, string fabricante, string lote)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataVencimento = dataVencimento;
            this.DataCadastro = dataCadastro;
            this.Fabricante = fabricante;
            this.Lote = lote;
        }
        public Reagente() { }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Lote { get => lote; set => lote = value; }
        public CategoriaReagente CategoriaReagente { get => categoriaReagente; set => categoriaReagente = value; }
    }
}
