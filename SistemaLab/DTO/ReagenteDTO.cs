using SistemaLab.Model.enums;

namespace SistemaLab.DTO
{
    public class ReagenteDTO
    {
        public string Nome { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Fabricante { get; private set; }
        public string Lote { get; private set; }
        public Caracteristica Caracteristicas { get; private set; }
        public TipoReagente Tipo { get; private set; }
        public EstadoFisico Estado { get; private set; }

        public ReagenteDTO(string nome, DateTime dataVencimento, DateTime dataCadastro, string fabricante, string lote, Caracteristica caracteristicas, TipoReagente tipo, EstadoFisico estado)
        {
            Nome = nome;
            DataVencimento = dataVencimento;
            DataCadastro = dataCadastro;
            Fabricante = fabricante;
            Lote = lote;
            Caracteristicas = caracteristicas;
            Tipo = tipo;
            Estado = estado;
        }

        public string ObterDetalhes()
        {
            return $"Nome: {Nome}\nData de Vencimento: {DataVencimento.ToShortDateString()}\nData de Cadastro: {DataCadastro.ToShortDateString()}\nFabricante: {Fabricante}\nLote: {Lote}\nCaracterísticas: {Caracteristicas}\nTipo: {Tipo}\nEstado: {Estado}";
        }
    }
}
