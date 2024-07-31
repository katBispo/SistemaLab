namespace SistemaLab.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            acessoRápidoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarReagenteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarResíduoToolStripMenuItem = new ToolStripMenuItem();
            listarReagenteToolStripMenuItem = new ToolStripMenuItem();
            listarResíduoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acessoRápidoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 144);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(307, 241);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 2;
            label1.Text = "Chemical Stock";
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
            // 
            // listarReagenteToolStripMenuItem
            // 
            listarReagenteToolStripMenuItem.Name = "listarReagenteToolStripMenuItem";
            listarReagenteToolStripMenuItem.Size = new Size(180, 22);
            listarReagenteToolStripMenuItem.Text = "Listar Reagente";
            // 
            // listarResíduoToolStripMenuItem
            // 
            listarResíduoToolStripMenuItem.Name = "listarResíduoToolStripMenuItem";
            listarResíduoToolStripMenuItem.Size = new Size(180, 22);
            listarResíduoToolStripMenuItem.Text = "Listar Resíduo";
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuView";
            Text = "MenuView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private ToolStripMenuItem cadastrarReagenteToolStripMenuItem;
        private ToolStripMenuItem cadastrarResíduoToolStripMenuItem;
        private ToolStripMenuItem listarReagenteToolStripMenuItem;
        private ToolStripMenuItem listarResíduoToolStripMenuItem;
    }
}