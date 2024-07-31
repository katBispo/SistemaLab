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
            gpbClassificacaoResiduo = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            dtpGeracaoResiduo = new DateTimePicker();
            label2 = new Label();
            cmbBoxCategoriaResiduo = new ComboBox();
            textBox3 = new TextBox();
            txtBoxNomeResiduo = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            gpbClassificacaoResiduo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(gpbClassificacaoResiduo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpGeracaoResiduo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbBoxCategoriaResiduo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtBoxNomeResiduo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 592);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(274, 491);
            button1.Name = "button1";
            button1.Size = new Size(156, 62);
            button1.TabIndex = 19;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gpbClassificacaoResiduo
            // 
            gpbClassificacaoResiduo.Controls.Add(checkBox5);
            gpbClassificacaoResiduo.Controls.Add(checkBox4);
            gpbClassificacaoResiduo.Controls.Add(checkBox3);
            gpbClassificacaoResiduo.Controls.Add(checkBox2);
            gpbClassificacaoResiduo.Controls.Add(checkBox1);
            gpbClassificacaoResiduo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbClassificacaoResiduo.ForeColor = SystemColors.ControlLight;
            gpbClassificacaoResiduo.Location = new Point(51, 235);
            gpbClassificacaoResiduo.Name = "gpbClassificacaoResiduo";
            gpbClassificacaoResiduo.Size = new Size(228, 177);
            gpbClassificacaoResiduo.TabIndex = 18;
            gpbClassificacaoResiduo.TabStop = false;
            gpbClassificacaoResiduo.Text = "Classificação";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(18, 146);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(73, 24);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Tóxico";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(18, 116);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(106, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Patogênico";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Reativo";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Inflamável";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Corrosivo";
            checkBox1.UseVisualStyleBackColor = true;
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
            label2.Size = new Size(103, 15);
            label2.TabIndex = 14;
            label2.Text = "Categoria Resíduo";
            // 
            // cmbBoxCategoriaResiduo
            // 
            cmbBoxCategoriaResiduo.AutoCompleteCustomSource.AddRange(new string[] { "Sal", "Ácido", "Base", "Óxido" });
            cmbBoxCategoriaResiduo.FormattingEnabled = true;
            cmbBoxCategoriaResiduo.Items.AddRange(new object[] { "Sal", "Ácido", "Base", "óxido" });
            cmbBoxCategoriaResiduo.Location = new Point(274, 178);
            cmbBoxCategoriaResiduo.Name = "cmbBoxCategoriaResiduo";
            cmbBoxCategoriaResiduo.Size = new Size(191, 23);
            cmbBoxCategoriaResiduo.TabIndex = 13;
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
            gpbClassificacaoResiduo.ResumeLayout(false);
            gpbClassificacaoResiduo.PerformLayout();
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
        private ComboBox cmbBoxCategoriaResiduo;
        private Button button1;
        private GroupBox gpbClassificacaoResiduo;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}