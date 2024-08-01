namespace SistemaLab
{
    partial class CadastrarUsuarioView
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtBoxEmail = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            txtBoxCPF = new TextBox();
            txtBoxMarca = new TextBox();
            txtBoxNomeUsuario = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(txtBoxEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBoxCPF);
            panel1.Controls.Add(txtBoxMarca);
            panel1.Controls.Add(txtBoxNomeUsuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(79, 248);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.PlaceholderText = "Email";
            txtBoxEmail.Size = new Size(191, 23);
            txtBoxEmail.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(293, 170);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 17;
            label3.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(293, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
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
            // txtBoxCPF
            // 
            txtBoxCPF.Location = new Point(302, 124);
            txtBoxCPF.Name = "txtBoxCPF";
            txtBoxCPF.PlaceholderText = "CPF";
            txtBoxCPF.Size = new Size(191, 23);
            txtBoxCPF.TabIndex = 12;
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Location = new Point(79, 188);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.PlaceholderText = "Telefone";
            txtBoxMarca.Size = new Size(191, 23);
            txtBoxMarca.TabIndex = 11;
            // 
            // txtBoxNomeUsuario
            // 
            txtBoxNomeUsuario.Location = new Point(79, 124);
            txtBoxNomeUsuario.Name = "txtBoxNomeUsuario";
            txtBoxNomeUsuario.PlaceholderText = "Nome do Usuário";
            txtBoxNomeUsuario.Size = new Size(191, 23);
            txtBoxNomeUsuario.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(79, 38);
            label1.Name = "label1";
            label1.Size = new Size(205, 29);
            label1.TabIndex = 9;
            label1.Text = "Cadastro de Usuário";
            // 
            // CadastrarUsuarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CadastrarUsuarioView";
            Text = "CadastrarUsuarioView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txtBoxCPF;
        private TextBox txtBoxMarca;
        private TextBox txtBoxNomeUsuario;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtBoxEmail;
        private ToolTip toolTip1;
    }
}