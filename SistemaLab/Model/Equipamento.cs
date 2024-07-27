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
        [Key]
        public int id { get; private set; }
        public string nomeEquipamento { get; private set; }
        public  StatusEquipamento statusEquipamento { get; private set; }
        public List<ReservaEquipamento> reservaEquipamentos { get; private set; }

        public Equipamento(int id, string nomeEquipamento, StatusEquipamento statusEquipamento)
        {
            this.Id = id;
            this.NomeEquipamento = nomeEquipamento;
            this.StatusEquipamento = statusEquipamento;
        }
        public Equipamento()
        {

        }

        public int Id { get => id; set => id = value; }
        public string NomeEquipamento { get => nomeEquipamento; set => nomeEquipamento = value; }
        public List<ReservaEquipamento> ReservaEquipamentos { get => reservaEquipamentos; set => reservaEquipamentos = value; }
        internal StatusEquipamento StatusEquipamento { get => statusEquipamento; set => statusEquipamento = value; }
    }
}
