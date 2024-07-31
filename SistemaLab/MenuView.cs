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
    }
}
