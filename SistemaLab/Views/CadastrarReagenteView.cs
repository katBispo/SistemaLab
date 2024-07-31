using System;
using System.Drawing.Text;
using System.Windows.Forms;
using SistemaLab.Controller;
using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;

namespace SistemaLab
{
    public partial class CadastrarReagenteView : Form
    {
        private ReagenteController reagenteController = new ReagenteController();

        public CadastrarReagenteView()
        {
            InitializeComponent();
           
        }

        private void cmbBoxTipoReagente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            ReagenteDTO reagente = new ReagenteDTO(txtNomeReagente.Text,  DateTime.Parse(dtpVencimentoReagente.Text), DateTime.Now, txtFabricante.Text, txtLote.Text);

            reagenteController.cadastrarReagente(reagente);


            string mensagem = "Reagente Cadastrado com sucesso";
            string titulo = "Atenção";
            MessageBox.Show(mensagem, titulo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
