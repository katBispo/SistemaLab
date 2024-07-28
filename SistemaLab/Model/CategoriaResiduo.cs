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
        public int idCategoria { get; private set; }
        public string categoria { get; private set; }

        public List<Residuo> residuos { get; private set; }

        public CategoriaResiduo(int idCategoria, string categoria)
        {
            this.idCategoria = idCategoria;
            this.categoria = categoria;
        }
        public CategoriaResiduo() { }


    }
}
