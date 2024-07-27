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
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public DateTime dataVencimento { get; private set; }
        public DateTime dataCadastro;
        public string fabricante { get; private set; }
        public string lote { get; private set; }

        [Column("id_usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; private set; }
        [Column("id_categoria")]
        public int CategoriaReagenteId { get; set; }
        public CategoriaReagente categoriaReagente {  get; private set; }

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
