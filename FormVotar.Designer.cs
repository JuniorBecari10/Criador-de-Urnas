namespace Criador_de_Urnas
{
    partial class FormVotar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVote = new System.Windows.Forms.Label();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblVice = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Você está votando para";
            // 
            // lblVote
            // 
            this.lblVote.AutoSize = true;
            this.lblVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVote.Location = new System.Drawing.Point(12, 33);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(93, 24);
            this.lblVote.TabIndex = 3;
            this.lblVote.Text = "<Secao>";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(355, 362);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(151, 28);
            this.btnBranco.TabIndex = 4;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(512, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(163, 40);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPartido);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblVice);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.ptbFoto);
            this.panel1.Location = new System.Drawing.Point(512, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 325);
            this.panel1.TabIndex = 6;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(15, 225);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(0, 13);
            this.lblPartido.TabIndex = 5;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(15, 242);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 13);
            this.lblNum.TabIndex = 3;
            // 
            // lblVice
            // 
            this.lblVice.AutoSize = true;
            this.lblVice.Location = new System.Drawing.Point(15, 205);
            this.lblVice.Name = "lblVice";
            this.lblVice.Size = new System.Drawing.Size(0, 13);
            this.lblVice.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 192);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 1;
            // 
            // ptbFoto
            // 
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbFoto.Location = new System.Drawing.Point(11, 46);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(140, 140);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            this.ptbFoto.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 316);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Retornar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Location = new System.Drawing.Point(198, 362);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(151, 28);
            this.btnCorrigir.TabIndex = 8;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(12, 362);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(151, 28);
            this.btnShowList.TabIndex = 9;
            this.btnShowList.Text = "Lista de Candidatos";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // txbInput
            // 
            this.txbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInput.Location = new System.Drawing.Point(228, 144);
            this.txbInput.MaxLength = 9;
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(208, 62);
            this.txbInput.TabIndex = 1;
            this.txbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            this.txbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dados do Candidato";
            // 
            // FormVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnCorrigir);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.lblVote);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVotar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votando para Urna: <Urna>, votar para <Secao>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVotar_FormClosed);
            this.Load += new System.EventHandler(this.FormVotar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVote;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblVice;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Label label2;
    }
}