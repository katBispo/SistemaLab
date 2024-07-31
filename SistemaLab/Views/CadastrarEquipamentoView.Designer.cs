namespace SistemaLab
{
    partial class CadastrarEquipamentoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            txtBoxModelo = new TextBox();
            txtBoxMarca = new TextBox();
            txtBoxNomeEquipamento = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBoxModelo);
            panel1.Controls.Add(txtBoxMarca);
            panel1.Controls.Add(txtBoxNomeEquipamento);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(260, 333);
            button1.Name = "button1";
            button1.Size = new Size(156, 62);
            button1.TabIndex = 13;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBoxModelo
            // 
            txtBoxModelo.Location = new Point(302, 124);
            txtBoxModelo.Name = "txtBoxModelo";
            txtBoxModelo.PlaceholderText = "Modelo";
            txtBoxModelo.Size = new Size(191, 23);
            txtBoxModelo.TabIndex = 12;
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Location = new Point(79, 188);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.PlaceholderText = "Marca";
            txtBoxMarca.Size = new Size(191, 23);
            txtBoxMarca.TabIndex = 11;
            // 
            // txtBoxNomeEquipamento
            // 
            txtBoxNomeEquipamento.Location = new Point(79, 124);
            txtBoxNomeEquipamento.Name = "txtBoxNomeEquipamento";
            txtBoxNomeEquipamento.PlaceholderText = "Nome do Equipamento";
            txtBoxNomeEquipamento.Size = new Size(191, 23);
            txtBoxNomeEquipamento.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(79, 38);
            label1.Name = "label1";
            label1.Size = new Size(257, 29);
            label1.TabIndex = 9;
            label1.Text = "Cadastro de Equipamento";
            // 
            // CadastrarEquipamentoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(panel1);
            Name = "CadastrarEquipamentoView";
            Text = "CadastrarEquipamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBoxModelo;
        private TextBox txtBoxMarca;
        private TextBox txtBoxNomeEquipamento;
        private Label label1;
        private Button button1;
    }
}