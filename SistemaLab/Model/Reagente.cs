using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Reagente
    {
        public int id { get;  set; }
        public string nome { get;  set; }
        public DateTime dataVencimento { get;  set; }
        public DateTime dataCadastro;
        public string fabricante { get;  set; }
        public string lote { get;  set; }

        public Usuario Usuario { get;  set; }
        public CategoriaReagente categoriaReagente {  get;  set; }

        public Reagente(int id, string nome, DateTime dataVencimento, DateTime dataCadastro, string fabricante, string lote)
        {
            this.id = id;
            this.nome = nome;
            this.dataVencimento = dataVencimento;
            this.dataCadastro = dataCadastro;
            this.fabricante = fabricante;
            this.lote = lote;
        }
        public Reagente() { }


    }
}
