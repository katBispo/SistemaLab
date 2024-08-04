using System;
using System.Drawing.Text;
using System.Windows.Forms;
using SistemaLab.Controller;
using SistemaLab.DAO.DAOImpl;
using SistemaLab.DTO;
using SistemaLab.Model;
using SistemaLab.Model.enums;

namespace SistemaLab
{
    public partial class CadastrarReagenteView : Form
    {
        private ReagenteController reagenteController = new ReagenteController();

        public CadastrarReagenteView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


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
        private void cmbBoxTipoReagente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            var caracteristicas = Caracteristica.Nenhuma;

            if (chkCorrosivo.Checked)
                caracteristicas |= Caracteristica.Corrosivo;
            if (chkInflamavel.Checked)
                caracteristicas |= Caracteristica.Inflamavel;
            if (chkReativo.Checked)
                caracteristicas |= Caracteristica.Reativo;
            if (chkPatogenico.Checked)
                caracteristicas |= Caracteristica.Patogenico;
            if (chkToxico.Checked)
                caracteristicas |= Caracteristica.Toxico;

            TipoReagente tipoReagente = (TipoReagente)cmbBoxTipoReagente.SelectedItem;
            EstadoFisico estadoFisico = radioButton1.Checked ? EstadoFisico.Solido : EstadoFisico.Liquido;


            // Cria um novo DTO com os dados do reagente, incluindo as características e o tipo
            ReagenteDTO reagente = new ReagenteDTO(
                txtNomeReagente.Text,
                DateTime.Parse(dtpVencimentoReagente.Text),
                DateTime.Now,
                txtFabricante.Text,
                txtLote.Text,
                caracteristicas,
                tipoReagente,
                estadoFisico
            );

            // Chama o método do controlador para cadastrar o reagente
            reagenteController.cadastrarReagente(reagente);

            // Obtém os detalhes do reagente cadastrado
            string detalhesReagente = reagente.ObterDetalhes();

            // Cria a mensagem de confirmação com os detalhes do reagente
            string mensagem = $"Reagente Cadastrado com sucesso!\n\n{detalhesReagente}";
            string titulo = "Confirmação";

            // Exibe a mensagem de confirmação
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CadastrarReagenteView_Load(object sender, EventArgs e)
        {
            cmbBoxTipoReagente.DataSource = Enum.GetValues(typeof(TipoReagente));
        }
    }
}
