using System;
using System.Drawing.Text;
using System.Windows.Forms;
using SistemaLab.DAO.DAOImpl;
using SistemaLab.Model;

namespace SistemaLab
{
    public partial class CadastrarReagenteView : Form
    {
        public CadastrarReagenteView()
        {
            InitializeComponent();
           
        }

        private void cmbBoxTipoReagente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reagente reagente = new Reagente();
            ReagenteDAOImpl reagenteDAO = new ReagenteDAOImpl();
            reagente.nome = txtNomeReagente.Text;
            reagente.lote = txtLote.Text;
            reagente.dataVencimento = DateTime.Parse(dateTimePicker1.Text);
            reagente.dataCadastro = DateTime.Now;
            CategoriaReagente categoriaReagente = new CategoriaReagente(1, cmbBoxTipoReagente.Text);
            reagente.categoriaReagente = categoriaReagente;

            reagenteDAO.inserir(reagente);



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
