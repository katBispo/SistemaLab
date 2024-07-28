using SistemaLab.DAO.DAOImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLab.Model;

namespace SistemaLab
{
    public partial class ListarReagenteView : Form
    {
        public ListarReagenteView()
        {
            InitializeComponent();
        }

        private void ListarReagenteView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReagenteDAOImpl re = new ReagenteDAOImpl();
            List<Reagente> reagentes = re.buscarTodos();

            List<String> nomesReagentes = new List<String>();

            foreach (Reagente r in reagentes)
            {
                nomesReagentes.Add(r.nome);
            }
            string mensagem = string.Join(Environment.NewLine, nomesReagentes);

            MessageBox.Show(mensagem);
        }
    }
}
