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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600); // Defina o tamanho desejado aqui (800x600, por exemplo)


        }

        private void cadastrarReagentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReagenteView cadastrarReagente = new CadastrarReagenteView();
            cadastrarReagente.Show();

        }

        private void cadastrarResíduosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarResiduoView cadastrarResiduo = new CadastrarResiduoView();
            cadastrarResiduo.Show();
        }

        private void listarReagentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarReagenteView listarReagente = new ListarReagenteView();
            listarReagente.Show();

        }

        private void listarResíduosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarResiduoView listarResiduo = new ListarResiduoView();
            listarResiduo.Show();
        }

        private void relatórioDeReagentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioReagenteView relatorioReagente = new RelatorioReagenteView();
            relatorioReagente.Show();
        }

        private void relatórioDeResíduosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioResiduoView relatorioResiduo = new RelatorioResiduoView();
            relatorioResiduo.Show();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }
    }
}
