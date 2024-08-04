namespace SistemaLab
{
    partial class CadastrarResiduoView
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
            label3 = new Label();
            dtpGeracaoResiduo = new DateTimePicker();
            label2 = new Label();
            cmbBoxTipoResiduo = new ComboBox();
            textBox3 = new TextBox();
            txtBoxNomeResiduo = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpGeracaoResiduo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbBoxTipoResiduo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtBoxNomeResiduo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 592);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(259, 361);
            button1.Name = "button1";
            button1.Size = new Size(156, 62);
            button1.TabIndex = 19;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(51, 160);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 16;
            label3.Text = "Data de geração";
            // 
            // dtpGeracaoResiduo
            // 
            dtpGeracaoResiduo.Location = new Point(51, 178);
            dtpGeracaoResiduo.Name = "dtpGeracaoResiduo";
            dtpGeracaoResiduo.Size = new Size(200, 23);
            dtpGeracaoResiduo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(274, 160);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 14;
            label2.Text = "Tipo Resíduo";
            // 
            // cmbBoxTipoResiduo
            // 
            cmbBoxTipoResiduo.AutoCompleteCustomSource.AddRange(new string[] { "Sal", "Ácido", "Base", "Óxido" });
            cmbBoxTipoResiduo.FormattingEnabled = true;
            cmbBoxTipoResiduo.Items.AddRange(new object[] { "Sal", "Ácido", "Base", "óxido" });
            cmbBoxTipoResiduo.Location = new Point(274, 178);
            cmbBoxTipoResiduo.Name = "cmbBoxTipoResiduo";
            cmbBoxTipoResiduo.Size = new Size(191, 23);
            cmbBoxTipoResiduo.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 116);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Número CAS";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 10;
            // 
            // txtBoxNomeResiduo
            // 
            txtBoxNomeResiduo.Location = new Point(51, 116);
            txtBoxNomeResiduo.Name = "txtBoxNomeResiduo";
            txtBoxNomeResiduo.PlaceholderText = "Nome do Resíduo";
            txtBoxNomeResiduo.Size = new Size(191, 23);
            txtBoxNomeResiduo.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Resíduos";
            // 
            // CadastrarResiduoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 592);
            Controls.Add(panel1);
            Name = "CadastrarResiduoView";
            Text = "CadastrarResiduo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox3;
        private TextBox txtBoxNomeResiduo;
        private Label label3;
        private DateTimePicker dtpGeracaoResiduo;
        private Label label2;
        private ComboBox cmbBoxTipoResiduo;
        private Button button1;
    }
}