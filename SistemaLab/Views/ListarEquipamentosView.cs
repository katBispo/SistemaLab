using SistemaLab.Controller;
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
    public partial class ListarEquipamentosView : Form
    {
        private EquipamentoController equipamentoController = new EquipamentoController();

        public ListarEquipamentosView()
        {
            InitializeComponent();
        }

        private void toolStripButtonCadastroEquipamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarEquipamentoView telaCadastrarEquipamento = new CadastrarEquipamentoView();
            telaCadastrarEquipamento.FormClosed += (s, args) => this.Close();
            telaCadastrarEquipamento.Show(this);
        }

        private void ListarEquipamentosView_Load(object sender, EventArgs e)
        {
            // Carregar dados no DataGridView ao carregar o formulário
            CarregarDados();
        }

        private void CarregarDados()
        {
            List<Equipamento> equipamentos = equipamentoController.listarEquipamento();
            dtvEquipamentos.DataSource = null;
            dtvEquipamentos.DataSource = equipamentos;

        }
    }
}
