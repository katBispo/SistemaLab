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
        [Key]
        public int id;
        public string nomeCategoria { get; private set; }

        public CategoriaReagente(int id, string nomeCategoria)
        {
            this.Id = id;
            this.NomeCategoria = nomeCategoria;
        }
        public CategoriaReagente() { }

        public int Id { get => id; set => id = value; }
        public string NomeCategoria { get => nomeCategoria; set => nomeCategoria = value; }

        public List<Reagente> reagentes { get; set; }

    }
}
