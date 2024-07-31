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
            acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarReagenteToolStripMenuItem });
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
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuView";
            Text = "MenuView";
            Load += this.MenuView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private ToolStripMenuItem cadastrarReagenteToolStripMenuItem;
    }
}