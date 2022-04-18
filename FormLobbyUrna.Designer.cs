namespace Criador_de_Urnas
{
    partial class FormLobbyUrna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLobbyUrna));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeUrna = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.btnScopeIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpSecoes = new System.Windows.Forms.TabPage();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPartidoEx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumEx = new System.Windows.Forms.Label();
            this.lblViceEx = new System.Windows.Forms.Label();
            this.lblNomeEx = new System.Windows.Forms.Label();
            this.ptbFotoEx = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkPartido = new System.Windows.Forms.CheckBox();
            this.chkNumero = new System.Windows.Forms.CheckBox();
            this.chkVice = new System.Windows.Forms.CheckBox();
            this.chkNome = new System.Windows.Forms.CheckBox();
            this.chkFoto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNulo = new System.Windows.Forms.CheckBox();
            this.chkBranco = new System.Windows.Forms.CheckBox();
            this.tbpEnd = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbFinalPhrase = new System.Windows.Forms.TextBox();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.grpSom = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.rdCustom = new System.Windows.Forms.RadioButton();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.btnTest = new System.Windows.Forms.Button();
            this.ofgSom = new System.Windows.Forms.OpenFileDialog();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveUrna = new System.Windows.Forms.Button();
            this.btnLoadUrna = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartReal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSalvamento = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tbpSecoes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoEx)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpEnd.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpSom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Urna:";
            // 
            // lblNomeUrna
            // 
            this.lblNomeUrna.AutoSize = true;
            this.lblNomeUrna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUrna.Location = new System.Drawing.Point(157, 12);
            this.lblNomeUrna.Name = "lblNomeUrna";
            this.lblNomeUrna.Size = new System.Drawing.Size(69, 20);
            this.lblNomeUrna.TabIndex = 1;
            this.lblNomeUrna.Text = "<Nome>";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(26, 35);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(121, 25);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Renomear";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seções";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(413, 311);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 28);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvSections
            // 
            this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.AllowUserToDeleteRows = false;
            this.dgvSections.AllowUserToResizeColumns = false;
            this.dgvSections.AllowUserToResizeRows = false;
            this.dgvSections.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSections.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.ColumnHeadersVisible = false;
            this.dgvSections.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSections.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSections.EnableHeadersVisualStyles = false;
            this.dgvSections.Location = new System.Drawing.Point(10, 40);
            this.dgvSections.MultiSelect = false;
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.ReadOnly = true;
            this.dgvSections.RowHeadersVisible = false;
            this.dgvSections.ShowCellErrors = false;
            this.dgvSections.ShowCellToolTips = false;
            this.dgvSections.ShowEditingIcon = false;
            this.dgvSections.ShowRowErrors = false;
            this.dgvSections.Size = new System.Drawing.Size(673, 259);
            this.dgvSections.TabIndex = 9;
            this.dgvSections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellClick);
            this.dgvSections.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellDoubleClick);
            this.dgvSections.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellMouseEnter);
            this.dgvSections.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellMouseLeave);
            this.dgvSections.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvSections_MouseMove);
            // 
            // btnScopeIn
            // 
            this.btnScopeIn.Enabled = false;
            this.btnScopeIn.Location = new System.Drawing.Point(179, 311);
            this.btnScopeIn.Name = "btnScopeIn";
            this.btnScopeIn.Size = new System.Drawing.Size(111, 28);
            this.btnScopeIn.TabIndex = 10;
            this.btnScopeIn.Text = "Focar";
            this.btnScopeIn.UseVisualStyleBackColor = true;
            this.btnScopeIn.Click += new System.EventHandler(this.btnScopeIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpar Lista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpSecoes);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Controls.Add(this.tbpEnd);
            this.tbcMain.Location = new System.Drawing.Point(12, 66);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(697, 378);
            this.tbcMain.TabIndex = 14;
            this.tbcMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbcMain_MouseMove);
            // 
            // tbpSecoes
            // 
            this.tbpSecoes.Controls.Add(this.btnRemoveLast);
            this.tbpSecoes.Controls.Add(this.dgvSections);
            this.tbpSecoes.Controls.Add(this.btnClear);
            this.tbpSecoes.Controls.Add(this.btnScopeIn);
            this.tbpSecoes.Controls.Add(this.label2);
            this.tbpSecoes.Controls.Add(this.btnRemove);
            this.tbpSecoes.Controls.Add(this.btnAdd);
            this.tbpSecoes.Location = new System.Drawing.Point(4, 22);
            this.tbpSecoes.Name = "tbpSecoes";
            this.tbpSecoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecoes.Size = new System.Drawing.Size(689, 352);
            this.tbpSecoes.TabIndex = 0;
            this.tbpSecoes.Text = "Seções";
            this.tbpSecoes.UseVisualStyleBackColor = true;
            this.tbpSecoes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpSecoes_MouseMove);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Enabled = false;
            this.btnRemoveLast.Location = new System.Drawing.Point(540, 311);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(143, 28);
            this.btnRemoveLast.TabIndex = 14;
            this.btnRemoveLast.Text = "Remover Última";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações da Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Obs.: Os dados do candidato que estão na cor cinza aqui, não estarão visíveis na " +
    "hora da votação.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPartidoEx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblNumEx);
            this.panel1.Controls.Add(this.lblViceEx);
            this.panel1.Controls.Add(this.lblNomeEx);
            this.panel1.Controls.Add(this.ptbFotoEx);
            this.panel1.Location = new System.Drawing.Point(520, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 325);
            this.panel1.TabIndex = 4;
            // 
            // lblPartidoEx
            // 
            this.lblPartidoEx.AutoSize = true;
            this.lblPartidoEx.Location = new System.Drawing.Point(15, 225);
            this.lblPartidoEx.Name = "lblPartidoEx";
            this.lblPartidoEx.Size = new System.Drawing.Size(40, 13);
            this.lblPartidoEx.TabIndex = 5;
            this.lblPartidoEx.Text = "Partido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Demonstração";
            // 
            // lblNumEx
            // 
            this.lblNumEx.AutoSize = true;
            this.lblNumEx.Location = new System.Drawing.Point(15, 242);
            this.lblNumEx.Name = "lblNumEx";
            this.lblNumEx.Size = new System.Drawing.Size(19, 13);
            this.lblNumEx.TabIndex = 3;
            this.lblNumEx.Text = "00";
            // 
            // lblViceEx
            // 
            this.lblViceEx.AutoSize = true;
            this.lblViceEx.Location = new System.Drawing.Point(15, 205);
            this.lblViceEx.Name = "lblViceEx";
            this.lblViceEx.Size = new System.Drawing.Size(94, 13);
            this.lblViceEx.TabIndex = 2;
            this.lblViceEx.Text = "Vice do Candidato";
            // 
            // lblNomeEx
            // 
            this.lblNomeEx.AutoSize = true;
            this.lblNomeEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEx.Location = new System.Drawing.Point(15, 192);
            this.lblNomeEx.Name = "lblNomeEx";
            this.lblNomeEx.Size = new System.Drawing.Size(118, 13);
            this.lblNomeEx.TabIndex = 1;
            this.lblNomeEx.Text = "Nome do Candidato";
            // 
            // ptbFotoEx
            // 
            this.ptbFotoEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFotoEx.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbFotoEx.Image = global::Criador_de_Urnas.Properties.Resources.download;
            this.ptbFotoEx.Location = new System.Drawing.Point(11, 46);
            this.ptbFotoEx.Name = "ptbFotoEx";
            this.ptbFotoEx.Size = new System.Drawing.Size(140, 140);
            this.ptbFotoEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoEx.TabIndex = 0;
            this.ptbFotoEx.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPartido);
            this.groupBox3.Controls.Add(this.chkNumero);
            this.groupBox3.Controls.Add(this.chkVice);
            this.groupBox3.Controls.Add(this.chkNome);
            this.groupBox3.Controls.Add(this.chkFoto);
            this.groupBox3.Location = new System.Drawing.Point(17, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar";
            // 
            // chkPartido
            // 
            this.chkPartido.AutoSize = true;
            this.chkPartido.Checked = true;
            this.chkPartido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPartido.Location = new System.Drawing.Point(6, 88);
            this.chkPartido.Name = "chkPartido";
            this.chkPartido.Size = new System.Drawing.Size(59, 17);
            this.chkPartido.TabIndex = 4;
            this.chkPartido.Text = "Partido";
            this.chkPartido.UseVisualStyleBackColor = true;
            this.chkPartido.CheckedChanged += new System.EventHandler(this.chkPartido_CheckedChanged);
            // 
            // chkNumero
            // 
            this.chkNumero.AutoSize = true;
            this.chkNumero.Location = new System.Drawing.Point(6, 111);
            this.chkNumero.Name = "chkNumero";
            this.chkNumero.Size = new System.Drawing.Size(63, 17);
            this.chkNumero.TabIndex = 3;
            this.chkNumero.Text = "Número";
            this.chkNumero.UseVisualStyleBackColor = true;
            this.chkNumero.CheckedChanged += new System.EventHandler(this.chkNumero_CheckedChanged);
            // 
            // chkVice
            // 
            this.chkVice.AutoSize = true;
            this.chkVice.Checked = true;
            this.chkVice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVice.Location = new System.Drawing.Point(6, 65);
            this.chkVice.Name = "chkVice";
            this.chkVice.Size = new System.Drawing.Size(47, 17);
            this.chkVice.TabIndex = 2;
            this.chkVice.Text = "Vice";
            this.chkVice.UseVisualStyleBackColor = true;
            this.chkVice.CheckedChanged += new System.EventHandler(this.chkVice_CheckedChanged);
            // 
            // chkNome
            // 
            this.chkNome.AutoSize = true;
            this.chkNome.Checked = true;
            this.chkNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNome.Location = new System.Drawing.Point(6, 42);
            this.chkNome.Name = "chkNome";
            this.chkNome.Size = new System.Drawing.Size(54, 17);
            this.chkNome.TabIndex = 1;
            this.chkNome.Text = "Nome";
            this.chkNome.UseVisualStyleBackColor = true;
            this.chkNome.CheckedChanged += new System.EventHandler(this.chkNome_CheckedChanged);
            // 
            // chkFoto
            // 
            this.chkFoto.AutoSize = true;
            this.chkFoto.Checked = true;
            this.chkFoto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoto.Location = new System.Drawing.Point(6, 19);
            this.chkFoto.Name = "chkFoto";
            this.chkFoto.Size = new System.Drawing.Size(47, 17);
            this.chkFoto.TabIndex = 0;
            this.chkFoto.Text = "Foto";
            this.chkFoto.UseVisualStyleBackColor = true;
            this.chkFoto.CheckedChanged += new System.EventHandler(this.chkFoto_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNulo);
            this.groupBox1.Controls.Add(this.chkBranco);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções Adicionais";
            // 
            // chkNulo
            // 
            this.chkNulo.AutoSize = true;
            this.chkNulo.Checked = true;
            this.chkNulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNulo.Location = new System.Drawing.Point(6, 42);
            this.chkNulo.Name = "chkNulo";
            this.chkNulo.Size = new System.Drawing.Size(48, 17);
            this.chkNulo.TabIndex = 1;
            this.chkNulo.Text = "Nulo";
            this.chkNulo.UseVisualStyleBackColor = true;
            this.chkNulo.CheckedChanged += new System.EventHandler(this.chkNulo_CheckedChanged);
            // 
            // chkBranco
            // 
            this.chkBranco.AutoSize = true;
            this.chkBranco.Checked = true;
            this.chkBranco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBranco.Location = new System.Drawing.Point(6, 19);
            this.chkBranco.Name = "chkBranco";
            this.chkBranco.Size = new System.Drawing.Size(60, 17);
            this.chkBranco.TabIndex = 0;
            this.chkBranco.Text = "Branco";
            this.chkBranco.UseVisualStyleBackColor = true;
            this.chkBranco.CheckedChanged += new System.EventHandler(this.chkBranco_CheckedChanged);
            // 
            // tbpEnd
            // 
            this.tbpEnd.AllowDrop = true;
            this.tbpEnd.Controls.Add(this.groupBox5);
            this.tbpEnd.Controls.Add(this.grpSom);
            this.tbpEnd.Location = new System.Drawing.Point(4, 22);
            this.tbpEnd.Name = "tbpEnd";
            this.tbpEnd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnd.Size = new System.Drawing.Size(689, 352);
            this.tbpEnd.TabIndex = 2;
            this.tbpEnd.Text = "Finalização";
            this.tbpEnd.UseVisualStyleBackColor = true;
            this.tbpEnd.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbpEnd_DragDrop);
            this.tbpEnd.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbpEnd_DragEnter);
            this.tbpEnd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpEnd_MouseMove);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.txbFinalPhrase);
            this.groupBox5.Controls.Add(this.lblPhrase);
            this.groupBox5.Location = new System.Drawing.Point(219, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 115);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frase";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbFinalPhrase
            // 
            this.txbFinalPhrase.Location = new System.Drawing.Point(12, 50);
            this.txbFinalPhrase.Name = "txbFinalPhrase";
            this.txbFinalPhrase.Size = new System.Drawing.Size(163, 20);
            this.txbFinalPhrase.TabIndex = 1;
            this.txbFinalPhrase.Text = "FIM";
            this.txbFinalPhrase.TextChanged += new System.EventHandler(this.txbFinalPhrase_TextChanged);
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(6, 20);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(137, 16);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "Frase de Finalização:";
            // 
            // grpSom
            // 
            this.grpSom.Controls.Add(this.label3);
            this.grpSom.Controls.Add(this.btnPlay);
            this.grpSom.Controls.Add(this.btnChoosePath);
            this.grpSom.Controls.Add(this.lblPath);
            this.grpSom.Controls.Add(this.txbPath);
            this.grpSom.Controls.Add(this.rdCustom);
            this.grpSom.Controls.Add(this.rdDefault);
            this.grpSom.Location = new System.Drawing.Point(10, 16);
            this.grpSom.Name = "grpSom";
            this.grpSom.Size = new System.Drawing.Size(188, 237);
            this.grpSom.TabIndex = 0;
            this.grpSom.TabStop = false;
            this.grpSom.Text = "Som";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dica: Você pode arrastar o arquivo\r\naté aqui para usá-lo.";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 173);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(172, 25);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Tocar Som";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(6, 109);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(172, 22);
            this.btnChoosePath.TabIndex = 4;
            this.btnChoosePath.Text = "Escolher Caminho";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 67);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(51, 13);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Caminho:";
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(6, 83);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(172, 20);
            this.txbPath.TabIndex = 2;
            // 
            // rdCustom
            // 
            this.rdCustom.AutoSize = true;
            this.rdCustom.Location = new System.Drawing.Point(6, 42);
            this.rdCustom.Name = "rdCustom";
            this.rdCustom.Size = new System.Drawing.Size(91, 17);
            this.rdCustom.TabIndex = 1;
            this.rdCustom.Text = "Personalizado";
            this.rdCustom.UseVisualStyleBackColor = true;
            this.rdCustom.CheckedChanged += new System.EventHandler(this.rdCustom_CheckedChanged);
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Checked = true;
            this.rdDefault.Location = new System.Drawing.Point(6, 19);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(59, 17);
            this.rdDefault.TabIndex = 0;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Padrão";
            this.rdDefault.UseVisualStyleBackColor = true;
            this.rdDefault.CheckedChanged += new System.EventHandler(this.rdDefault_CheckedChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(151, 44);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Iniciar Votação de Teste";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ofgSom
            // 
            this.ofgSom.FileOk += new System.ComponentModel.CancelEventHandler(this.ofgSom_FileOk);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(719, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 25);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Retornar ao Menu Principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveUrna
            // 
            this.btnSaveUrna.Location = new System.Drawing.Point(3, 73);
            this.btnSaveUrna.Name = "btnSaveUrna";
            this.btnSaveUrna.Size = new System.Drawing.Size(151, 44);
            this.btnSaveUrna.TabIndex = 17;
            this.btnSaveUrna.Text = "Salvar Urna";
            this.btnSaveUrna.UseVisualStyleBackColor = true;
            this.btnSaveUrna.Click += new System.EventHandler(this.btnSaveUrna_Click);
            // 
            // btnLoadUrna
            // 
            this.btnLoadUrna.Location = new System.Drawing.Point(3, 19);
            this.btnLoadUrna.Name = "btnLoadUrna";
            this.btnLoadUrna.Size = new System.Drawing.Size(151, 48);
            this.btnLoadUrna.TabIndex = 18;
            this.btnLoadUrna.Text = "Carregar Urna";
            this.btnLoadUrna.UseVisualStyleBackColor = true;
            this.btnLoadUrna.Click += new System.EventHandler(this.btnLoadUrna_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartReal);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Location = new System.Drawing.Point(719, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 117);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Votação";
            // 
            // btnStartReal
            // 
            this.btnStartReal.Location = new System.Drawing.Point(6, 65);
            this.btnStartReal.Name = "btnStartReal";
            this.btnStartReal.Size = new System.Drawing.Size(151, 44);
            this.btnStartReal.TabIndex = 16;
            this.btnStartReal.Text = "Iniciar Votação";
            this.btnStartReal.UseVisualStyleBackColor = true;
            this.btnStartReal.Click += new System.EventHandler(this.btnStartReal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadUrna);
            this.groupBox4.Controls.Add(this.btnSaveUrna);
            this.groupBox4.Location = new System.Drawing.Point(719, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 131);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salvamento";
            // 
            // lblSalvamento
            // 
            this.lblSalvamento.AutoSize = true;
            this.lblSalvamento.Location = new System.Drawing.Point(719, 414);
            this.lblSalvamento.Name = "lblSalvamento";
            this.lblSalvamento.Size = new System.Drawing.Size(161, 13);
            this.lblSalvamento.TabIndex = 21;
            this.lblSalvamento.Text = "Você tem alterações não salvas.";
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 500;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // FormLobbyUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 447);
            this.Controls.Add(this.lblSalvamento);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblNomeUrna);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLobbyUrna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Urnas - Editar Urna: <Nome>";
            this.Activated += new System.EventHandler(this.FormLobbyUrna_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLobbyUrna_FormClosed);
            this.Load += new System.EventHandler(this.FormLobbyUrna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tbpSecoes.ResumeLayout(false);
            this.tbpSecoes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoEx)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpEnd.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpSom.ResumeLayout(false);
            this.grpSom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeUrna;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.Button btnScopeIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpSecoes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.CheckBox chkNulo;
        private System.Windows.Forms.CheckBox chkBranco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFoto;
        private System.Windows.Forms.CheckBox chkNumero;
        private System.Windows.Forms.CheckBox chkVice;
        private System.Windows.Forms.CheckBox chkNome;
        private System.Windows.Forms.TabPage tbpEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbFotoEx;
        private System.Windows.Forms.Label lblNomeEx;
        private System.Windows.Forms.Label lblNumEx;
        private System.Windows.Forms.Label lblViceEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox grpSom;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.RadioButton rdCustom;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofgSom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbFinalPhrase;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkPartido;
        private System.Windows.Forms.Label lblPartidoEx;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveUrna;
        private System.Windows.Forms.Button btnLoadUrna;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartReal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSalvamento;
        private System.Windows.Forms.Timer tmrTick;
    }
}