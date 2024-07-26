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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
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
            menuStrip1.Size = new Size(862, 24);
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
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 661);
            panel1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(331, 414);
            button3.Name = "button3";
            button3.Size = new Size(156, 62);
            button3.TabIndex = 6;
            button3.Text = "USUÁRIOS";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(554, 292);
            button2.Name = "button2";
            button2.Size = new Size(156, 62);
            button2.TabIndex = 5;
            button2.Text = "EQUIPAMENTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(331, 292);
            button1.Name = "button1";
            button1.Size = new Size(156, 62);
            button1.TabIndex = 4;
            button1.Text = "RESÍDUO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(92, 292);
            button4.Name = "button4";
            button4.Size = new Size(156, 62);
            button4.TabIndex = 0;
            button4.Text = "REAGENTE";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(247, 159);
            label3.Name = "label3";
            label3.Size = new Size(220, 32);
            label3.TabIndex = 3;
            label3.Text = "Chemical Stock";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 692);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += MenuView_Load;
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}