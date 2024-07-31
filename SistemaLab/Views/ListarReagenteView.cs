using SistemaLab.Controller;
using SistemaLab.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaLab
{
    public partial class ListarReagenteView : Form
    {
        private ReagenteController reagenteController = new ReagenteController();

        public ListarReagenteView()
        {
            InitializeComponent();
        }

        private void ListarReagenteView_Load(object sender, EventArgs e)
        {
            // Carregar dados no DataGridView ao carregar o formulário
            CarregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            List<Reagente> reagentes = reagenteController.listarReagentes();
            dgvReagente.DataSource = null;

            dgvReagente.DataSource = reagentes;
        }

        private void dgvReagente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarReagenteView telaCadastroReagente = new CadastrarReagenteView();
            telaCadastroReagente.FormClosed += (s, args) => this.Close();
            telaCadastroReagente.Show(this);
        }
    }
}
