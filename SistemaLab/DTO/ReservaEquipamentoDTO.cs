using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class ReservaEquipamentoDTO
    {
        public ReservaEquipamentoDTO(DateTime data, Aluno reservista, Equipamento equipamento)
        {
            this.data = data;
            this.reservista = reservista;
            this.equipamento = equipamento;
        }

        public DateTime data { get; private set; }

        public Aluno reservista { get; private set; }


        public Equipamento equipamento { get; private set; }
    }
}
