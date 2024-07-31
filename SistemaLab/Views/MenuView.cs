using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLab
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarReagenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReagenteView telaCadastrarReagente = new CadastrarReagenteView();
            telaCadastrarReagente.MdiParent = this;
            telaCadastrarReagente.Show();
        }

        private void cadastrarResíduoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarResiduoView telaCadastrarResiduo = new CadastrarResiduoView();
            telaCadastrarResiduo.MdiParent = this;
            telaCadastrarResiduo.Show();
        }

        private void listarReagenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarReagenteView telaListarReagente = new ListarReagenteView();
            telaListarReagente.MdiParent = this;
            telaListarReagente.Show();
        }

        private void listarResíduoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarResiduoView telaListarResiduo = new ListarResiduoView();
            telaListarResiduo.MdiParent= this;
            telaListarResiduo.Show();
        }
    }
}
