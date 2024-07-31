namespace SistemaLab
{
    partial class ListarReagenteView
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
            label1 = new Label();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonCadastro = new ToolStripButton();
            toolStripButtonRelatorio = new ToolStripButton();
            button1 = new Button();
            dgvReagente = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReagente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 1;
            label1.Text = "Lista de Reagentes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(63, 111);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonCadastro, toolStripButtonRelatorio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 37);
            toolStrip1.TabIndex = 3;
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
            toolStripButtonCadastro.Click += toolStripButtonCadastro_Click;
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
            // button1
            // 
            button1.Location = new Point(320, 382);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 4;
            button1.Text = "Teste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvReagente
            // 
            dgvReagente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReagente.Location = new Point(41, 148);
            dgvReagente.Name = "dgvReagente";
            dgvReagente.Size = new Size(717, 204);
            dgvReagente.TabIndex = 5;
            dgvReagente.CellContentClick += dgvReagente_CellContentClick;
            // 
            // ListarReagenteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReagente);
            Controls.Add(button1);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ListarReagenteView";
            Text = "ListarReagenteView";
            Load += ListarReagenteView_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReagente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCadastro;
        private ToolStripButton toolStripButtonRelatorio;
        private Button button1;
        private DataGridView dgvReagente;
    }
}