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

            EquipamentoDTO equipamento = new EquipamentoDTO(txtBoxNomeEquipamento.Text, txtBoxModelo.Text, txtBoxMarca.Text);

         
            equipamentoController.cadastrarEquipamento(equipamento);

            string mensagem = "Equipamento Cadastrado com sucesso";
            string titulo = "Atenção";
            MessageBox.Show(mensagem, titulo);
        }
    }
}
