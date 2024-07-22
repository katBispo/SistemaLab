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
            cadastrarReagentesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarResíduosToolStripMenuItem = new ToolStripMenuItem();
            listarReagentesToolStripMenuItem = new ToolStripMenuItem();
            listarResíduosToolStripMenuItem = new ToolStripMenuItem();
            gerarRelatóriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeReagentesToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeResíduosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acessoRápidoToolStripMenuItem, gerarRelatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // acessoRápidoToolStripMenuItem
            // 
            acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarReagentesToolStripMenuItem, cadastrarResíduosToolStripMenuItem, listarReagentesToolStripMenuItem, listarResíduosToolStripMenuItem });
            acessoRápidoToolStripMenuItem.Name = "acessoRápidoToolStripMenuItem";
            acessoRápidoToolStripMenuItem.Size = new Size(96, 20);
            acessoRápidoToolStripMenuItem.Text = "Acesso Rápido";
            // 
            // cadastrarReagentesToolStripMenuItem
            // 
            cadastrarReagentesToolStripMenuItem.Name = "cadastrarReagentesToolStripMenuItem";
            cadastrarReagentesToolStripMenuItem.Size = new Size(181, 22);
            cadastrarReagentesToolStripMenuItem.Text = "Cadastrar Reagentes";
            cadastrarReagentesToolStripMenuItem.Click += cadastrarReagentesToolStripMenuItem_Click;
            // 
            // cadastrarResíduosToolStripMenuItem
            // 
            cadastrarResíduosToolStripMenuItem.Name = "cadastrarResíduosToolStripMenuItem";
            cadastrarResíduosToolStripMenuItem.Size = new Size(181, 22);
            cadastrarResíduosToolStripMenuItem.Text = "Cadastrar Resíduos";
            cadastrarResíduosToolStripMenuItem.Click += cadastrarResíduosToolStripMenuItem_Click;
            // 
            // listarReagentesToolStripMenuItem
            // 
            listarReagentesToolStripMenuItem.Name = "listarReagentesToolStripMenuItem";
            listarReagentesToolStripMenuItem.Size = new Size(181, 22);
            listarReagentesToolStripMenuItem.Text = "Listar Reagentes";
            listarReagentesToolStripMenuItem.Click += listarReagentesToolStripMenuItem_Click;
            // 
            // listarResíduosToolStripMenuItem
            // 
            listarResíduosToolStripMenuItem.Name = "listarResíduosToolStripMenuItem";
            listarResíduosToolStripMenuItem.Size = new Size(181, 22);
            listarResíduosToolStripMenuItem.Text = "Listar Resíduos";
            listarResíduosToolStripMenuItem.Click += listarResíduosToolStripMenuItem_Click;
            // 
            // gerarRelatóriosToolStripMenuItem
            // 
            gerarRelatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeReagentesToolStripMenuItem, relatórioDeResíduosToolStripMenuItem });
            gerarRelatóriosToolStripMenuItem.Name = "gerarRelatóriosToolStripMenuItem";
            gerarRelatóriosToolStripMenuItem.Size = new Size(102, 20);
            gerarRelatóriosToolStripMenuItem.Text = "Gerar Relatórios";
            // 
            // relatórioDeReagentesToolStripMenuItem
            // 
            relatórioDeReagentesToolStripMenuItem.Name = "relatórioDeReagentesToolStripMenuItem";
            relatórioDeReagentesToolStripMenuItem.Size = new Size(194, 22);
            relatórioDeReagentesToolStripMenuItem.Text = "Relatório de Reagentes";
            relatórioDeReagentesToolStripMenuItem.Click += relatórioDeReagentesToolStripMenuItem_Click;
            // 
            // relatórioDeResíduosToolStripMenuItem
            // 
            relatórioDeResíduosToolStripMenuItem.Name = "relatórioDeResíduosToolStripMenuItem";
            relatórioDeResíduosToolStripMenuItem.Size = new Size(194, 22);
            relatórioDeResíduosToolStripMenuItem.Text = "Relatório de Resíduos";
            relatórioDeResíduosToolStripMenuItem.Click += relatórioDeResíduosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 423);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.frasco60;
            pictureBox1.Location = new Point(71, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 68);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 3;
            label3.Text = "Chemical Stock";
            // 
            // panel2
            // 
            panel2.Location = new Point(190, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 426);
            panel2.TabIndex = 4;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuView";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private ToolStripMenuItem cadastrarReagentesToolStripMenuItem;
        private ToolStripMenuItem cadastrarResíduosToolStripMenuItem;
        private ToolStripMenuItem listarReagentesToolStripMenuItem;
        private ToolStripMenuItem listarResíduosToolStripMenuItem;
        private ToolStripMenuItem gerarRelatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeReagentesToolStripMenuItem;
        private ToolStripMenuItem relatórioDeResíduosToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
    }
}