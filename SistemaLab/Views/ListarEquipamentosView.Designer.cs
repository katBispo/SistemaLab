namespace SistemaLab
{
    partial class ListarEquipamentosView
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
            dtvEquipamentos = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripButtonCadastroEquipamento = new ToolStripButton();
            toolStripButtonRelatorio = new ToolStripButton();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvEquipamentos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(dtvEquipamentos);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // dtvEquipamentos
            // 
            dtvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvEquipamentos.Location = new Point(63, 155);
            dtvEquipamentos.Name = "dtvEquipamentos";
            dtvEquipamentos.Size = new Size(650, 150);
            dtvEquipamentos.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonCadastroEquipamento, toolStripButtonRelatorio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 37);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCadastroEquipamento
            // 
            toolStripButtonCadastroEquipamento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCadastroEquipamento.Image = Properties.Resources.adicionar1;
            toolStripButtonCadastroEquipamento.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonCadastroEquipamento.ImageTransparentColor = Color.Magenta;
            toolStripButtonCadastroEquipamento.Name = "toolStripButtonCadastroEquipamento";
            toolStripButtonCadastroEquipamento.Size = new Size(34, 34);
            toolStripButtonCadastroEquipamento.Text = "toolStripButton1";
            toolStripButtonCadastroEquipamento.Click += toolStripButtonCadastroEquipamento_Click;
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
            label1.Location = new Point(48, 78);
            label1.Name = "label1";
            label1.Size = new Size(228, 29);
            label1.TabIndex = 2;
            label1.Text = "Lista de Equipamentos";
            // 
            // ListarEquipamentosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ListarEquipamentosView";
            Text = "ListarEquipamentos";
            Load += ListarEquipamentosView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvEquipamentos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCadastroEquipamento;
        private ToolStripButton toolStripButtonRelatorio;
        private DataGridView dtvEquipamentos;
    }
}