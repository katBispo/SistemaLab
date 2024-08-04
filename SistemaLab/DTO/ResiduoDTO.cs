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
        public ResiduoDTO(string nome, DateTime dataGeracao, TipoResiduo tipo)
        {
            Nome = nome;
            DataGeracao = dataGeracao;
            Tipo = tipo;
        }

        public string Nome { get; private set; }
        public DateTime DataGeracao { get; private set; }
        public TipoResiduo Tipo { get; private set; }

        public string ObterDetalhes()
        {
            return $"Nome: {Nome}\nData de Geração: {DataGeracao.ToShortDateString()}\nTipo: {Tipo}";
        }
    }
}
