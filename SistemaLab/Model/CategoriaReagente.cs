using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Model
{
    public class CategoriaReagente
    {
        public int id {  get; set; }
        public string nomeCategoria { get;  set; }

        public CategoriaReagente(int id, string nomeCategoria)
        {
            this.id = id;
            this.nomeCategoria = nomeCategoria;
        }
        public CategoriaReagente() { }


        public List<Reagente> reagentes { get; set; }

    }
}
