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
            groupBox2 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cmbBoxTipoResiduo = new ComboBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbBoxTipoResiduo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(51, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 177);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Classificação";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(51, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
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
            // textBox1
            // 
            textBox1.Location = new Point(51, 116);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome do Resíduo";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 9;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cmbBoxTipoResiduo;
        private Button button1;
        private GroupBox groupBox2;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}