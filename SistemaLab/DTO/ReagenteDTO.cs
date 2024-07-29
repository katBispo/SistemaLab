using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class ReagenteDTO
    {
        public string nome { get; private set; }
        public DateTime dataVencimento { get; private set; }
        public DateTime dataCadastro {  get; private set; }

        public ReagenteDTO(string nome, DateTime dataVencimento, DateTime dataCadastro, string fabricante, string lote)
        {
            this.nome = nome;
            this.dataVencimento = dataVencimento;
            this.dataCadastro = dataCadastro;
            this.fabricante = fabricante;
            this.lote = lote;
        }

        public string fabricante { get; private set; }
        public string lote { get; private set; }

        
    }
}
