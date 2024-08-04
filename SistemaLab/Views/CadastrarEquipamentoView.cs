using SistemaLab.Controller;
using SistemaLab.DAO.DAOImpl;
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
    public partial class CadastrarEquipamentoView : Form
    {
        private EquipamentoController equipamentoController = new EquipamentoController();

        public CadastrarEquipamentoView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um novo DTO com os dados do equipamento
            EquipamentoDTO equipamento = new EquipamentoDTO(txtBoxNomeEquipamento.Text, txtBoxModelo.Text, txtBoxMarca.Text);

            // Chama o método do controlador para cadastrar o equipamento
            equipamentoController.cadastrarEquipamento(equipamento);

            // Obtém os detalhes do equipamento cadastrado
            string detalhesEquipamento = equipamento.ObterDetalhes();

            // Cria a mensagem de confirmação com os detalhes do equipamento
            string mensagem = $"Equipamento Cadastrado com sucesso!\n\n{detalhesEquipamento}";
            string titulo = "Confirmação";

            // Exibe a mensagem de confirmação
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
