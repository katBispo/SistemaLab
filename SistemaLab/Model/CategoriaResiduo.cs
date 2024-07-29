using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class CategoriaResiduo
    {
        public int id { get;  set; }
        public string categoria { get;  set; }

        public List<Residuo> residuos { get; private set; }

        public CategoriaResiduo(int id, string categoria)
        {
            this.id = id;
            this.categoria = categoria;
        }
        public CategoriaResiduo() { }


    }
}
