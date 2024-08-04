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
            // Oculte os controles do formulário pai, exceto o MenuStrip
            foreach (Control control in this.Controls)
            {
                if (!(control is MdiClient || control is MenuStrip)) // Excluir MdiClient e MenuStrip
                {
                    control.Visible = false;
                }
            }
            CadastrarReagenteView telaCadastrarReagente = new CadastrarReagenteView();
            telaCadastrarReagente.MdiParent = this;
            //telaCadastrarReagente.WindowState = FormWindowState.Maximized;  
            
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
        // Método para restaurar os controles do formulário pai, caso necessário
        public void RestoreParentControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }
    }
}
