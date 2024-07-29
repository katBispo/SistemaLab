using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLab.Controller
{
    public class ReagenteController
    {
        private ReagenteDAOImpl dao = new ReagenteDAOImpl();

        public void cadastrarReagente(ReagenteDTO reagente)
        {
            Reagente r = new Reagente();
            r.nome = reagente.nome;
            r.dataVencimento = reagente.dataVencimento;
            r.fabricante = reagente.fabricante;
            r.dataCadastro = reagente.dataCadastro;
            r.lote = reagente.lote;

            dao.inserir(r);

        }
        public List<Reagente> listarReagentes()
        {
            return dao.buscarTodos();
        }

        public void excluirReagente(Reagente reagente)
        {
            dao.remover(reagente);
        }

    }
}
