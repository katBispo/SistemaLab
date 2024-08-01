namespace SistemaLab
{
    partial class MenuView
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
            menuStrip1 = new MenuStrip();
            acessoRápidoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarReagenteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarResíduoToolStripMenuItem = new ToolStripMenuItem();
            listarReagenteToolStripMenuItem = new ToolStripMenuItem();
            listarResíduoToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label6 = new Label();
            btnCadastrarReagente = new Button();
            btnListarReagente = new Button();
            btnListarResiduo = new Button();
            btnCadastrarResiduo = new Button();
            btnListarEquipamento = new Button();
            btnCadastrarEquipamento = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acessoRápidoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // acessoRápidoToolStripMenuItem
            // 
            acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarReagenteToolStripMenuItem, cadastrarResíduoToolStripMenuItem, listarReagenteToolStripMenuItem, listarResíduoToolStripMenuItem });
            acessoRápidoToolStripMenuItem.Name = "acessoRápidoToolStripMenuItem";
            acessoRápidoToolStripMenuItem.Size = new Size(96, 20);
            acessoRápidoToolStripMenuItem.Text = "Acesso Rápido";
            // 
            // cadastrarReagenteToolStripMenuItem
            // 
            cadastrarReagenteToolStripMenuItem.Name = "cadastrarReagenteToolStripMenuItem";
            cadastrarReagenteToolStripMenuItem.Size = new Size(176, 22);
            cadastrarReagenteToolStripMenuItem.Text = "Cadastrar Reagente";
            cadastrarReagenteToolStripMenuItem.Click += cadastrarReagenteToolStripMenuItem_Click;
            // 
            // cadastrarResíduoToolStripMenuItem
            // 
            cadastrarResíduoToolStripMenuItem.Name = "cadastrarResíduoToolStripMenuItem";
            cadastrarResíduoToolStripMenuItem.Size = new Size(176, 22);
            cadastrarResíduoToolStripMenuItem.Text = "Cadastrar Resíduo";
            cadastrarResíduoToolStripMenuItem.Click += cadastrarResíduoToolStripMenuItem_Click;
            // 
            // listarReagenteToolStripMenuItem
            // 
            listarReagenteToolStripMenuItem.Name = "listarReagenteToolStripMenuItem";
            listarReagenteToolStripMenuItem.Size = new Size(176, 22);
            listarReagenteToolStripMenuItem.Text = "Listar Reagente";
            listarReagenteToolStripMenuItem.Click += listarReagenteToolStripMenuItem_Click;
            // 
            // listarResíduoToolStripMenuItem
            // 
            listarResíduoToolStripMenuItem.Name = "listarResíduoToolStripMenuItem";
            listarResíduoToolStripMenuItem.Size = new Size(176, 22);
            listarResíduoToolStripMenuItem.Text = "Listar Resíduo";
            listarResíduoToolStripMenuItem.Click += listarResíduoToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(297, 121);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(249, 73);
            label6.Name = "label6";
            label6.Size = new Size(293, 38);
            label6.TabIndex = 9;
            label6.Text = "CHEMICAL STOCK";
            // 
            // btnCadastrarReagente
            // 
            btnCadastrarReagente.BackColor = Color.DarkGreen;
            btnCadastrarReagente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarReagente.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarReagente.Location = new Point(80, 228);
            btnCadastrarReagente.Name = "btnCadastrarReagente";
            btnCadastrarReagente.Size = new Size(140, 46);
            btnCadastrarReagente.TabIndex = 11;
            btnCadastrarReagente.Text = "CADASTRAR REAGENTE";
            btnCadastrarReagente.UseVisualStyleBackColor = false;
            // 
            // btnListarReagente
            // 
            btnListarReagente.BackColor = Color.DarkGreen;
            btnListarReagente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarReagente.ForeColor = SystemColors.ButtonHighlight;
            btnListarReagente.Location = new Point(80, 300);
            btnListarReagente.Name = "btnListarReagente";
            btnListarReagente.Size = new Size(140, 46);
            btnListarReagente.TabIndex = 12;
            btnListarReagente.Text = "LISTAR REAGENTES";
            btnListarReagente.UseVisualStyleBackColor = false;
            // 
            // btnListarResiduo
            // 
            btnListarResiduo.BackColor = Color.DarkGreen;
            btnListarResiduo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarResiduo.ForeColor = SystemColors.ButtonHighlight;
            btnListarResiduo.Location = new Point(325, 300);
            btnListarResiduo.Name = "btnListarResiduo";
            btnListarResiduo.Size = new Size(140, 46);
            btnListarResiduo.TabIndex = 14;
            btnListarResiduo.Text = "LISTAR RESÍDUOS";
            btnListarResiduo.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarResiduo
            // 
            btnCadastrarResiduo.BackColor = Color.DarkGreen;
            btnCadastrarResiduo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarResiduo.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarResiduo.Location = new Point(325, 228);
            btnCadastrarResiduo.Name = "btnCadastrarResiduo";
            btnCadastrarResiduo.Size = new Size(140, 46);
            btnCadastrarResiduo.TabIndex = 13;
            btnCadastrarResiduo.Text = "CADASTRAR RESÍDUO";
            btnCadastrarResiduo.UseVisualStyleBackColor = false;
            // 
            // btnListarEquipamento
            // 
            btnListarEquipamento.BackColor = Color.DarkGreen;
            btnListarEquipamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarEquipamento.ForeColor = SystemColors.ButtonHighlight;
            btnListarEquipamento.Location = new Point(561, 300);
            btnListarEquipamento.Name = "btnListarEquipamento";
            btnListarEquipamento.Size = new Size(140, 46);
            btnListarEquipamento.TabIndex = 16;
            btnListarEquipamento.Text = "LISTAR EQUIPAMENTOS";
            btnListarEquipamento.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarEquipamento
            // 
            btnCadastrarEquipamento.BackColor = Color.DarkGreen;
            btnCadastrarEquipamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarEquipamento.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarEquipamento.Location = new Point(561, 228);
            btnCadastrarEquipamento.Name = "btnCadastrarEquipamento";
            btnCadastrarEquipamento.Size = new Size(140, 46);
            btnCadastrarEquipamento.TabIndex = 15;
            btnCadastrarEquipamento.Text = "CADASTRAR EQUIPAMENTO";
            btnCadastrarEquipamento.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 376);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 18;
            label1.Text = "zzzzzzzzzzzzzz";
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnListarEquipamento);
            Controls.Add(btnCadastrarEquipamento);
            Controls.Add(btnListarResiduo);
            Controls.Add(btnCadastrarResiduo);
            Controls.Add(btnListarReagente);
            Controls.Add(btnCadastrarReagente);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDarkDark;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuView";
            Text = "MenuView";
            Load += MenuView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private ToolStripMenuItem cadastrarReagenteToolStripMenuItem;
        private ToolStripMenuItem cadastrarResíduoToolStripMenuItem;
        private ToolStripMenuItem listarReagenteToolStripMenuItem;
        private ToolStripMenuItem listarResíduoToolStripMenuItem;
        private Label label3;
        private Label label6;
        private Button btnCadastrarReagente;
        private Button btnListarReagente;
        private Button btnListarResiduo;
        private Button btnCadastrarResiduo;
        private Button btnListarEquipamento;
        private Button btnCadastrarEquipamento;
        private Label label1;
    }
}