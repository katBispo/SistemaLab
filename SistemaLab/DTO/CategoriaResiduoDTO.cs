using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.DTO
{
    public class CategoriaResiduoDTO
    {
        public CategoriaResiduoDTO(string categoria)
        {
            this.categoria = categoria;
        }
       
        public string categoria { get; private set; }
    }
}
