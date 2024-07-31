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
            cadastrarReagenteToolStripMenuItem.Size = new Size(180, 22);
            cadastrarReagenteToolStripMenuItem.Text = "Cadastrar Reagente";
            cadastrarReagenteToolStripMenuItem.Click += cadastrarReagenteToolStripMenuItem_Click;
            // 
            // cadastrarResíduoToolStripMenuItem
            // 
            cadastrarResíduoToolStripMenuItem.Name = "cadastrarResíduoToolStripMenuItem";
            cadastrarResíduoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarResíduoToolStripMenuItem.Text = "Cadastrar Resíduo";
            cadastrarResíduoToolStripMenuItem.Click += cadastrarResíduoToolStripMenuItem_Click;
            // 
            // listarReagenteToolStripMenuItem
            // 
            listarReagenteToolStripMenuItem.Name = "listarReagenteToolStripMenuItem";
            listarReagenteToolStripMenuItem.Size = new Size(180, 22);
            listarReagenteToolStripMenuItem.Text = "Listar Reagente";
            listarReagenteToolStripMenuItem.Click += listarReagenteToolStripMenuItem_Click;
            // 
            // listarResíduoToolStripMenuItem
            // 
            listarResíduoToolStripMenuItem.Name = "listarResíduoToolStripMenuItem";
            listarResíduoToolStripMenuItem.Size = new Size(180, 22);
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
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
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
    }
}