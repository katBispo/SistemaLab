using SistemaLab.Model.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Equipamento
    {
        public int id { get;  set; }
        public string nomeEquipamento { get;  set; }
        public  StatusEquipamento statusEquipamento { get;  set; }
        public List<ReservaEquipamento> reservaEquipamentos { get;   set; }

        public Equipamento(int id, string nomeEquipamento, StatusEquipamento statusEquipamento)
        {
            this.id = id;
            this.nomeEquipamento = nomeEquipamento;
            this.statusEquipamento = statusEquipamento;
        }
        public Equipamento()
        {

        }


    }
}
