using SistemaLab.Model.enums;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class ResiduoDTO
    {
        public ResiduoDTO(string nome, DateTime dataGeracao, StatusResiduo statusResiduo, CategoriaResiduo categoriaResiduo)
        {
            this.nome = nome;
            this.dataGeracao = dataGeracao;
            this.statusResiduo = statusResiduo;
            this.categoriaResiduo = categoriaResiduo;
        }

        public string nome { get; private set; }
        public DateTime dataGeracao { get; private set; }
        public StatusResiduo statusResiduo { get; private set; }

        public CategoriaResiduo categoriaResiduo { get; private set; }
    }
}
