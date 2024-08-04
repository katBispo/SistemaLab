namespace SistemaLab
{
    partial class CadastrarReagenteView
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
            label1 = new Label();
            txtNomeReagente = new TextBox();
            txtLote = new TextBox();
            txtFabricante = new TextBox();
            radioButton1 = new RadioButton();
            rbLiquido = new RadioButton();
            groupBox1 = new GroupBox();
            cmbBoxTipoReagente = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dtpVencimentoReagente = new DateTimePicker();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            chkCorrosivo = new CheckBox();
            chkInflamavel = new CheckBox();
            chkReativo = new CheckBox();
            chkPatogenico = new CheckBox();
            chkToxico = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(232, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Reagentes";
            // 
            // txtNomeReagente
            // 
            txtNomeReagente.Location = new Point(78, 108);
            txtNomeReagente.Name = "txtNomeReagente";
            txtNomeReagente.PlaceholderText = "Nome do Reagente";
            txtNomeReagente.Size = new Size(191, 23);
            txtNomeReagente.TabIndex = 1;
            txtNomeReagente.TextChanged += textBox1_TextChanged;
            // 
            // txtLote
            // 
            txtLote.Location = new Point(78, 172);
            txtLote.Name = "txtLote";
            txtLote.PlaceholderText = "Lote";
            txtLote.Size = new Size(191, 23);
            txtLote.TabIndex = 2;
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(301, 108);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.PlaceholderText = "Fabricante";
            txtFabricante.Size = new Size(191, 23);
            txtFabricante.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 45);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sólido";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbLiquido
            // 
            rbLiquido.AutoSize = true;
            rbLiquido.Location = new Point(123, 45);
            rbLiquido.Name = "rbLiquido";
            rbLiquido.Size = new Size(79, 24);
            rbLiquido.TabIndex = 5;
            rbLiquido.TabStop = true;
            rbLiquido.Text = "Líquido";
            rbLiquido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbLiquido);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(333, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado do Reagente";
            // 
            // cmbBoxTipoReagente
            // 
            cmbBoxTipoReagente.AutoCompleteCustomSource.AddRange(new string[] { "Sal", "Ácido", "Base", "Óxido" });
            cmbBoxTipoReagente.FormattingEnabled = true;
            cmbBoxTipoReagente.Items.AddRange(new object[] { "Base", "Ácido", "Orgânico", "Óxido" });
            cmbBoxTipoReagente.Location = new Point(301, 172);
            cmbBoxTipoReagente.Name = "cmbBoxTipoReagente";
            cmbBoxTipoReagente.Size = new Size(191, 23);
            cmbBoxTipoReagente.TabIndex = 7;
            cmbBoxTipoReagente.SelectedIndexChanged += cmbBoxTipoReagente_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(301, 154);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo Reagente";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(288, 500);
            button1.Name = "button1";
            button1.Size = new Size(156, 62);
            button1.TabIndex = 9;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpVencimentoReagente
            // 
            dtpVencimentoReagente.Location = new Point(78, 236);
            dtpVencimentoReagente.Name = "dtpVencimentoReagente";
            dtpVencimentoReagente.Size = new Size(200, 23);
            dtpVencimentoReagente.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(78, 218);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Validade";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // chkCorrosivo
            // 
            chkCorrosivo.AutoSize = true;
            chkCorrosivo.Location = new Point(18, 26);
            chkCorrosivo.Name = "chkCorrosivo";
            chkCorrosivo.Size = new Size(95, 24);
            chkCorrosivo.TabIndex = 9;
            chkCorrosivo.Text = "Corrosivo";
            chkCorrosivo.UseVisualStyleBackColor = true;
            // 
            // chkInflamavel
            // 
            chkInflamavel.AutoSize = true;
            chkInflamavel.Location = new Point(18, 56);
            chkInflamavel.Name = "chkInflamavel";
            chkInflamavel.Size = new Size(102, 24);
            chkInflamavel.TabIndex = 10;
            chkInflamavel.Text = "Inflamável";
            chkInflamavel.UseVisualStyleBackColor = true;
            // 
            // chkReativo
            // 
            chkReativo.AutoSize = true;
            chkReativo.Location = new Point(18, 86);
            chkReativo.Name = "chkReativo";
            chkReativo.Size = new Size(81, 24);
            chkReativo.TabIndex = 11;
            chkReativo.Text = "Reativo";
            chkReativo.UseVisualStyleBackColor = true;
            // 
            // chkPatogenico
            // 
            chkPatogenico.AutoSize = true;
            chkPatogenico.Location = new Point(18, 116);
            chkPatogenico.Name = "chkPatogenico";
            chkPatogenico.Size = new Size(106, 24);
            chkPatogenico.TabIndex = 12;
            chkPatogenico.Text = "Patogênico";
            chkPatogenico.UseVisualStyleBackColor = true;
            // 
            // chkToxico
            // 
            chkToxico.AutoSize = true;
            chkToxico.Location = new Point(18, 146);
            chkToxico.Name = "chkToxico";
            chkToxico.Size = new Size(73, 24);
            chkToxico.TabIndex = 13;
            chkToxico.Text = "Tóxico";
            chkToxico.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkToxico);
            groupBox2.Controls.Add(chkPatogenico);
            groupBox2.Controls.Add(chkReativo);
            groupBox2.Controls.Add(chkInflamavel);
            groupBox2.Controls.Add(chkCorrosivo);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(78, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 177);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Classificação";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // CadastrarReagenteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(702, 574);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dtpVencimentoReagente);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(cmbBoxTipoReagente);
            Controls.Add(groupBox1);
            Controls.Add(txtFabricante);
            Controls.Add(txtLote);
            Controls.Add(txtNomeReagente);
            Controls.Add(label1);
            Name = "CadastrarReagenteView";
            Text = "Classificação Reagente";
            WindowState = FormWindowState.Maximized;
            Load += CadastrarReagenteView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeReagente;
        private TextBox txtLote;
        private TextBox txtFabricante;
        private RadioButton radioButton1;
        private RadioButton rbLiquido;
        private GroupBox groupBox1;
        private ComboBox cmbBoxTipoReagente;
        private Label label2;
        private Button button1;
        private DateTimePicker dtpVencimentoReagente;
        private Label label3;
        private PictureBox pictureBox1;
        private CheckBox chkCorrosivo;
        private CheckBox chkInflamavel;
        private CheckBox chkReativo;
        private CheckBox chkPatogenico;
        private CheckBox chkToxico;
        private GroupBox groupBox2;
    }
}