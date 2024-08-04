using SistemaLab.Controller;
using SistemaLab.DTO;
using SistemaLab.Model;
using SistemaLab.Model.enums;
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
        {// Obter o tipo de resíduo da combobox
            TipoResiduo tipoResiduo;
            Enum.TryParse(cmbBoxTipoResiduo.SelectedItem.ToString(), out tipoResiduo);
            cmbBoxTipoResiduo.DataSource = Enum.GetValues(typeof(TipoResiduo));



            // Criar o DTO do resíduo com todas as informações
            ResiduoDTO residuoDTO = new ResiduoDTO(
                txtBoxNomeResiduo.Text,
                DateTime.Parse(dtpGeracaoResiduo.Text),
                tipoResiduo
            );

            // Cadastrar o resíduo
            residuoController.cadastrarResiduo(residuoDTO);

            // Obtém os detalhes do resíduo cadastrado
            string detalhesResiduo = residuoDTO.ObterDetalhes();

            // Cria a mensagem de confirmação com os detalhes do resíduo
            string mensagem = $"Resíduo Cadastrado com sucesso!\n\n{detalhesResiduo}";
            string titulo = "Confirmação";

            // Exibe a mensagem de confirmação
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
