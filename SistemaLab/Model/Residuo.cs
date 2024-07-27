using SistemaLab.Model.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Residuo
    {
        [Key]
        public int id { get; private set; }
        public string nome { get;  set; }
        public DateTime dataGeracao { get;  set; }
        public StatusResiduo statusResiduo { get;  set; }

        public Residuo(int id, string nome, DateTime dataGeracao, StatusResiduo statusResiduo)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataGeracao = dataGeracao;
            this.StatusResiduo = statusResiduo;
        }
        public Residuo() { }    

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataGeracao { get => dataGeracao; set => dataGeracao = value; }
        internal StatusResiduo StatusResiduo { get => statusResiduo; set => statusResiduo = value; }
    }
}
