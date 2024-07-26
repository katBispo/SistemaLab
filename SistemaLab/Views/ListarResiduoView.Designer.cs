namespace SistemaLab
{
    partial class ListarResiduoView
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
            toolStrip1 = new ToolStrip();
            toolStripButtonCadastro = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonRelatorio = new ToolStripButton();
            label1 = new Label();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonCadastro, toolStripButtonEditar, toolStripButtonRelatorio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 37);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCadastro
            // 
            toolStripButtonCadastro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCadastro.Image = Properties.Resources.adicionar1;
            toolStripButtonCadastro.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonCadastro.ImageTransparentColor = Color.Magenta;
            toolStripButtonCadastro.Name = "toolStripButtonCadastro";
            toolStripButtonCadastro.Size = new Size(34, 34);
            toolStripButtonCadastro.Text = "toolStripButton1";
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = Properties.Resources.editar__1_;
            toolStripButtonEditar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 34);
            toolStripButtonEditar.Text = "toolStripButton2";
            // 
            // toolStripButtonRelatorio
            // 
            toolStripButtonRelatorio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRelatorio.Image = Properties.Resources.documento__1_;
            toolStripButtonRelatorio.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonRelatorio.ImageTransparentColor = Color.Magenta;
            toolStripButtonRelatorio.Name = "toolStripButtonRelatorio";
            toolStripButtonRelatorio.Size = new Size(34, 34);
            toolStripButtonRelatorio.Text = "toolStripButton1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(56, 73);
            label1.Name = "label1";
            label1.Size = new Size(180, 29);
            label1.TabIndex = 5;
            label1.Text = "Lista de Resíduos";
            // 
            // ListarResiduoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ListarResiduoView";
            Text = "ListarResiduoView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCadastro;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonRelatorio;
        private Label label1;
    }
}