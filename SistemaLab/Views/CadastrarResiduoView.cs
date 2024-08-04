using SistemaLab.Controller;
using SistemaLab.DTO;
using SistemaLab.Model;
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
    public partial class CadastrarResiduoView : Form

    {
        private ResiduoController residuoController = new ResiduoController();

        public CadastrarResiduoView()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Quando o formulário filho for fechado, restaura os controles do formulário pai
            if (this.MdiParent is MenuView mainForm)
            {
                mainForm.RestoreParentControls();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaResiduoDTO categoriaResiduoDTO = new CategoriaResiduoDTO(cmbBoxCategoriaResiduo.Text);
            CategoriaResiduo categoriaResiduo = new CategoriaResiduo(0, categoriaResiduoDTO.categoria);
            ResiduoDTO residuo = new ResiduoDTO(txtBoxNomeResiduo.Text, DateTime.Parse(dtpGeracaoResiduo.Text), categoriaResiduo);

            residuoController.cadastrarResiduo(residuo);


            string mensagem = "Resíduo Cadastrado com sucesso";
            string titulo = "Atenção";
            MessageBox.Show(mensagem, titulo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
