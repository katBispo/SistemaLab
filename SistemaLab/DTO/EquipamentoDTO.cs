using SistemaLab.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class EquipamentoDTO
    {
        public EquipamentoDTO(string nomeEquipamento, StatusEquipamento statusEquipamento)
        {
            this.nomeEquipamento = nomeEquipamento;
            this.statusEquipamento = statusEquipamento;
        }

        public string nomeEquipamento { get; private set; }
        public StatusEquipamento statusEquipamento { get; private set; }

    }
}
