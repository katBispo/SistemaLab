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
    public partial class ListarResiduoView : Form
    {
        private ResiduoController residuoController = new ResiduoController();

        public ListarResiduoView()
        {
            InitializeComponent();
        }

        private void ListarResiduoView_Load(object sender, EventArgs e)
        {
            // Carregar dados no DataGridView ao carregar o formulário
            CarregarDados();
        }

        private void CarregarDados()
        {
            List<Residuo> residuos = residuoController.listarResiduo();

            var resultado = from res in residuos
                            select new
                            {
                                res.nome,
                                res.dataGeracao,
                                Categoria = res.categoriaResiduo.categoria // Ajuste conforme a estrutura da sua classe
                            };

            // Configura o DataGridView
            dtvResiduo.DataSource = null;
            dtvResiduo.DataSource = resultado.ToList(); dtvResiduo.DataSource = null;


        }

        private void toolStripButtonCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarResiduoView telaCadastroResiduo = new CadastrarResiduoView();
            telaCadastroResiduo.FormClosed += (s, args) => this.Close();
            telaCadastroResiduo.Show(this);
        }

        private void dtvResiduo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
