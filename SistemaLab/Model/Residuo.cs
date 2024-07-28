﻿using SistemaLab.Model.enums;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class Residuo
    {
        public int id { get; private set; }
        public string nome { get;  set; }
        public DateTime dataGeracao { get;  set; }
        public StatusResiduo statusResiduo { get;  set; }

        public CategoriaResiduo categoriaResiduo { get; set; }

        public Usuario usuario {get; set; }

        public Residuo(int id, string nome, DateTime dataGeracao, StatusResiduo statusResiduo)
        {
            this.id = id;
            this.nome = nome;
            this.dataGeracao = dataGeracao;
            this.statusResiduo = statusResiduo;
        }
        public Residuo() { }    


    }
}
