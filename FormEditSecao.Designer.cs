namespace Criador_de_Urnas
{
    partial class FormEditSecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditSecao));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeSecao = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEditCandidatos = new System.Windows.Forms.Button();
            this.lblQtdDgt = new System.Windows.Forms.Label();
            this.nmcQtdDgt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQtdDgt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Seção:";
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSecao.Location = new System.Drawing.Point(142, 9);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(59, 16);
            this.lblNomeSecao.TabIndex = 1;
            this.lblNomeSecao.Text = "<Nome>";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(17, 33);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(112, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Renomear";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(472, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 38);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Retornar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditCandidatos
            // 
            this.btnEditCandidatos.Location = new System.Drawing.Point(373, 255);
            this.btnEditCandidatos.Name = "btnEditCandidatos";
            this.btnEditCandidatos.Size = new System.Drawing.Size(231, 45);
            this.btnEditCandidatos.TabIndex = 5;
            this.btnEditCandidatos.Text = "Candidatos";
            this.btnEditCandidatos.UseVisualStyleBackColor = true;
            this.btnEditCandidatos.Click += new System.EventHandler(this.btnEditCandidatos_Click);
            // 
            // lblQtdDgt
            // 
            this.lblQtdDgt.AutoSize = true;
            this.lblQtdDgt.Location = new System.Drawing.Point(370, 192);
            this.lblQtdDgt.Name = "lblQtdDgt";
            this.lblQtdDgt.Size = new System.Drawing.Size(248, 13);
            this.lblQtdDgt.TabIndex = 7;
            this.lblQtdDgt.Text = "Quantidade de dígitos para o número do candidato";
            // 
            // nmcQtdDgt
            // 
            this.nmcQtdDgt.Location = new System.Drawing.Point(373, 219);
            this.nmcQtdDgt.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmcQtdDgt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcQtdDgt.Name = "nmcQtdDgt";
            this.nmcQtdDgt.Size = new System.Drawing.Size(232, 20);
            this.nmcQtdDgt.TabIndex = 8;
            this.nmcQtdDgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcQtdDgt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcQtdDgt.ValueChanged += new System.EventHandler(this.nmcQtdDgt_ValueChanged);
            // 
            // FormEditSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 314);
            this.Controls.Add(this.nmcQtdDgt);
            this.Controls.Add(this.lblQtdDgt);
            this.Controls.Add(this.btnEditCandidatos);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblNomeSecao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditSecao";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Urnas - Editar Seção: <Secao>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditSecao_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormEditSecao_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.nmcQtdDgt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeSecao;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditCandidatos;
        private System.Windows.Forms.Label lblQtdDgt;
        private System.Windows.Forms.NumericUpDown nmcQtdDgt;
    }
}