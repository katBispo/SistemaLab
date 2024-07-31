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
            var lista = reagentes.Select(reagente => new
            {
                Nome = reagente.nome,
                Fabricante = reagente.fabricante,
                Categoria = reagente.categoriaReagente != null ? reagente.categoriaReagente.nomeCategoria : "Sem Categoria",
                DataVencimento = reagente.dataVencimento,
                DataCadastro = reagente.dataCadastro,
                Lote = reagente.lote
            }).ToList();
            dgvReagente.DataSource = null;

            dgvReagente.DataSource = lista;
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
