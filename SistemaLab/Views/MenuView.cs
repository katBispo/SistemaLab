using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLab.Views
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void cadastrarReagenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReagenteView cadastrarReagente  =  new CadastrarReagenteView();
            cadastrarReagente.MdiParent = this;
            cadastrarReagente.Show();
        }
    }
}
