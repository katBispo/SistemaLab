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
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            cmbBoxTipoReagente = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            dtpVencimentoReagente = new DateTimePicker();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(123, 45);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Líquido";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
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
            Load += CadastrarReagenteView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeReagente;
        private TextBox txtLote;
        private TextBox txtFabricante;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private ComboBox cmbBoxTipoReagente;
        private Label label2;
        private GroupBox groupBox2;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
        private DateTimePicker dtpVencimentoReagente;
        private Label label3;
        private PictureBox pictureBox1;
    }
}