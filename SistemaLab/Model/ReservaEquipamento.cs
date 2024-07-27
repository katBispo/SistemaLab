using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column("id_aluno")]
        public int AlunoId { get; set; }
        public Aluno reservista { get;  set; }


        [Column("id_equipamento")]
        public int EquipamentoId { get; set; }
        public Equipamento equipamento { get;  set; }


        public ReservaEquipamento(int id, DateTime data, Aluno reservista, Equipamento equipamento)
        {
            this.id = id;
            this.data = data;
            this.reservista = reservista;
            this.equipamento = equipamento;
        }
        public ReservaEquipamento() { }

  
    }
}
