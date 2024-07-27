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
        [Key]
        public int idCategoria { get; private set; }
        public string categoria { get; private set; }

        public CategoriaResiduo(int idCategoria, string categoria)
        {
            this.IdCategoria = idCategoria;
            this.Categoria = categoria;
        }
        public CategoriaResiduo() { }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
