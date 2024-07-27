using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class ReservaEquipamento
    {
        [Key]
        public int id { get;  set; }
        public DateTime data { get;  set; }
        public int AlunoId { get; set; }

        public Aluno reservista { get;  set; }

        public int EquipamentoId { get; set; }
        public Equipamento equipamento { get;  set; }

        public ReservaEquipamento(int id, DateTime data, Aluno reservista, Equipamento equipamento)
        {
            this.Id = id;
            this.Data = data;
            this.Reservista = reservista;
            this.Equipamento = equipamento;
        }
        public ReservaEquipamento() { }

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public Aluno Reservista { get => reservista; set => reservista = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
    }
}
