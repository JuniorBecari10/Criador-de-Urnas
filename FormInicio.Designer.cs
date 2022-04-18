namespace Criador_de_Urnas
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewUrna = new System.Windows.Forms.Button();
            this.btnChooseSavedUrna = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criador de Urnas";
            // 
            // btnNewUrna
            // 
            this.btnNewUrna.Location = new System.Drawing.Point(140, 79);
            this.btnNewUrna.Name = "btnNewUrna";
            this.btnNewUrna.Size = new System.Drawing.Size(239, 82);
            this.btnNewUrna.TabIndex = 1;
            this.btnNewUrna.Text = "Criar nova Urna";
            this.btnNewUrna.UseVisualStyleBackColor = true;
            this.btnNewUrna.Click += new System.EventHandler(this.btnNewUrna_Click);
            // 
            // btnChooseSavedUrna
            // 
            this.btnChooseSavedUrna.Location = new System.Drawing.Point(171, 176);
            this.btnChooseSavedUrna.Name = "btnChooseSavedUrna";
            this.btnChooseSavedUrna.Size = new System.Drawing.Size(178, 46);
            this.btnChooseSavedUrna.TabIndex = 2;
            this.btnChooseSavedUrna.Text = "Escolher urna salva";
            this.btnChooseSavedUrna.UseVisualStyleBackColor = true;
            this.btnChooseSavedUrna.Click += new System.EventHandler(this.btnChooseSavedUrna_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(480, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(171, 228);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(178, 33);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Testar urna e botões";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 281);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnChooseSavedUrna);
            this.Controls.Add(this.btnNewUrna);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Urnas - Início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewUrna;
        private System.Windows.Forms.Button btnChooseSavedUrna;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnTest;
    }
}

