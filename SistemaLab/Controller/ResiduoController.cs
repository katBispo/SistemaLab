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
    public class ResiduoController
    {
        private ResiduoDAOImpl dao = new ResiduoDAOImpl();

        public void cadastrarResiduo(ResiduoDTO residuo)
        {
            Residuo r = new Residuo();
            r.nome = residuo.nome;
            r.categoriaResiduo = residuo.categoriaResiduo;
            r.dataGeracao = residuo.dataGeracao;
            r.categoriaResiduo = residuo.categoriaResiduo;
            dao.inserir(r);

        }
        public List<Residuo> listarResiduo()
        {
            return dao.buscarTodos();
        }

        public void excluirResiduoe(Residuo residuo)
        {
            dao.remover(residuo);
        }

    }
}
