namespace Criador_de_Urnas
{
    partial class FormResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResults));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.lblSecao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvViewSections = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrancos = new System.Windows.Forms.Label();
            this.lblNulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSections)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado da Votação";
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            this.dgvCandidatos.AllowUserToResizeColumns = false;
            this.dgvCandidatos.AllowUserToResizeRows = false;
            this.dgvCandidatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(10, 66);
            this.dgvCandidatos.MultiSelect = false;
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.Size = new System.Drawing.Size(522, 319);
            this.dgvCandidatos.TabIndex = 1;
            this.dgvCandidatos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCandidatos_MouseMove);
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(217, 29);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(87, 13);
            this.lblSecao.TabIndex = 2;
            this.lblSecao.Text = "Seção: <Seção>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewSections);
            this.groupBox1.Location = new System.Drawing.Point(541, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 424);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Seção";
            // 
            // dgvViewSections
            // 
            this.dgvViewSections.AllowUserToAddRows = false;
            this.dgvViewSections.AllowUserToDeleteRows = false;
            this.dgvViewSections.AllowUserToResizeColumns = false;
            this.dgvViewSections.AllowUserToResizeRows = false;
            this.dgvViewSections.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvViewSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSections.Location = new System.Drawing.Point(5, 19);
            this.dgvViewSections.MultiSelect = false;
            this.dgvViewSections.Name = "dgvViewSections";
            this.dgvViewSections.ReadOnly = true;
            this.dgvViewSections.RowHeadersVisible = false;
            this.dgvViewSections.ShowCellErrors = false;
            this.dgvViewSections.ShowCellToolTips = false;
            this.dgvViewSections.ShowEditingIcon = false;
            this.dgvViewSections.ShowRowErrors = false;
            this.dgvViewSections.Size = new System.Drawing.Size(150, 399);
            this.dgvViewSections.TabIndex = 4;
            this.dgvViewSections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewSections_CellClick);
            this.dgvViewSections.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvViewSections_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brancos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nulos:";
            // 
            // lblBrancos
            // 
            this.lblBrancos.AutoSize = true;
            this.lblBrancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrancos.Location = new System.Drawing.Point(87, 401);
            this.lblBrancos.Name = "lblBrancos";
            this.lblBrancos.Size = new System.Drawing.Size(15, 16);
            this.lblBrancos.TabIndex = 6;
            this.lblBrancos.Text = "0";
            // 
            // lblNulos
            // 
            this.lblNulos.AutoSize = true;
            this.lblNulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulos.Location = new System.Drawing.Point(87, 417);
            this.lblNulos.Name = "lblNulos";
            this.lblNulos.Size = new System.Drawing.Size(15, 16);
            this.lblNulos.TabIndex = 7;
            this.lblNulos.Text = "0";
            // 
            // FormResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 444);
            this.Controls.Add(this.lblNulos);
            this.Controls.Add(this.lblBrancos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSecao);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Urnas - Resultado da Votação da Urna: <Urna>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormResults_FormClosed);
            this.Load += new System.EventHandler(this.FormResults_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormResults_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvViewSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrancos;
        private System.Windows.Forms.Label lblNulos;
    }
}