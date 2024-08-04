using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;

namespace SistemaLab.Controller
{
    public class ReagenteController
    {
        private ReagenteDAOImpl dao = new ReagenteDAOImpl();

        public void cadastrarReagente(ReagenteDTO reagente)
        {
            Reagente r = new Reagente
            {
                Nome = reagente.Nome,
                DataVencimento = reagente.DataVencimento,
                DataCadastro = reagente.DataCadastro,
                Fabricante = reagente.Fabricante,
                Lote = reagente.Lote,
                Caracteristicas = reagente.Caracteristicas,
                Tipo = reagente.Tipo,
                Estado = reagente.Estado
            };

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
