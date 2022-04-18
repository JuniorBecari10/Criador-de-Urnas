using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;

namespace Criador_de_Urnas
{
    public partial class FormLobbyUrna : Form
    {
        public static bool saved = false;
        public static int numSecoes = 0;

        public static string[] files = new string[1];
        public static string endSound { get; set; }

        public static string finalPhrase = "FIM";

        // true = normal, false = teste
        public static bool actualMode = false;

        public static bool isDefaultSound = true;

        public static int selectedSectionIndex = 0;

        private FormRename rename;
        private static DataTable dt;

        public static List<Secao> secoes;

        private static FormLobbyUrna lobby;

        public static bool[] adicionais = { true, true };
        public static bool[] show = { true, true, true, true, false };

        /*
         * loadMode
         * 
         * true = quando vc clica no modo de carregar uma urna existente na tela inicial
         * false = vc cria uma nova urna
         */

        public FormLobbyUrna(bool loadMode)
        {
            InitializeComponent();

            lobby = this;

            secoes = new List<Secao>();

            this.DragDrop += new DragEventHandler(tbpEnd_DragDrop);
            this.DragEnter += new DragEventHandler(tbpEnd_DragEnter);

            ofgSom.Filter = "Arquivos de Áudio|*.mp3;*.wav";

            this.Text = "Criador de Urnas - Editar Urna: " + FormSetUrnaName.nomeUrna;
            lblNomeUrna.Text = FormSetUrnaName.nomeUrna;

            rename = new FormRename();

            dt = new DataTable();
            dt.Columns.Add("Seções", typeof(string));

            dgvSections.DataSource = dt;
            dgvSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            soundCheckChanged();

            if (loadMode)
                load(FormInicio.fileName);
        }

        public static FormLobbyUrna getLobbyUrna()
        {
            return lobby;
        }

        public static void updateTable()
        {
            if (numSecoes == 0)
                return;

            int index = 0;

            foreach (DataRow dr in dt.Rows)
            {
                dr["Seções"] = secoes[index].nome;

                index++;
            }
        }

        public static void updateDeserializedTable()
        {
            dt.Rows.Clear();

            foreach (Candidato c in secoes[selectedSectionIndex].candidatos)
                dt.Rows.Add(c.nome);

            updateTable();
        }

        private void FormLobbyUrna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (rename.IsDisposed)
                rename = new FormRename();

            rename.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numSecoes++;

            Secao s = new Secao("Vazia", numSecoes);
            secoes.Add(s);

            dt.Rows.Add(s.nome);

            saved = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja remover a Seção selecionada?", "Confirmação de Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                return;

            if (numSecoes == 0)
                return;

            numSecoes--;

            secoes.RemoveAt(selectedSectionIndex);
            dt.Rows.RemoveAt(selectedSectionIndex);

            saved = false;
        }

        private void dgvSections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            new FormEditSecao().Show();
        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < secoes.Count)
            selectedSectionIndex = e.RowIndex;
        }

        private void btnScopeIn_Click(object sender, EventArgs e)
        {
            if (dgvSections.SelectedRows == null)
                return;

            this.Hide();
            new FormEditSecao().Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que quer limpar a lista de Seções? \nLembre que essa ação é irreversível.", "Confirmação de Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                numSecoes = 0;

                dt.Clear();
                secoes.Clear();
                selectedSectionIndex = 0;

                saved = false;
            }
        }

        private void mouseMove()
        {
            if (saved)
                lblSalvamento.Text = "Tudo salvo.";
            else
                lblSalvamento.Text = "Você tem alterações não salvas.";

            this.Text = "Criador de Urnas - Editar Urna: " + FormSetUrnaName.nomeUrna;
            lblNomeUrna.Text = FormSetUrnaName.nomeUrna;

            if (numSecoes == 0)
            {
                btnRemove.Enabled = false;
                btnRemoveLast.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnRemoveLast.Enabled = true;
            }

            if (dgvSections.SelectedRows == null || numSecoes == 0)
                btnScopeIn.Enabled = false;
            else if (dgvSections.SelectedRows != null || numSecoes > 0)
                btnScopeIn.Enabled = true;
        }

        private void tbpSecoes_MouseMove(object sender, MouseEventArgs e) // corrigir esse alterações não salvas.
        {
            mouseMove();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja remover a última Seção da lista?", "Confirmação de Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                return;

            if (numSecoes == 0)
                return;

            numSecoes--;

            secoes.RemoveAt(numSecoes);
            dt.Rows.RemoveAt(numSecoes);

            saved = false;
        }

        private void chkFoto_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged();

            saved = false;
        }

        private void chkNome_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged();

            saved = false;
        }

        private void chkVice_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged();

            saved = false;
        }

        private void chkNumero_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged();

            saved = false;
        }

        private void chkPartido_CheckedChanged(object sender, EventArgs e)
        {
            chkChanged();

            saved = false;
        }

        private void chkChanged()
        {
            ptbFotoEx.Image = chkFoto.Checked ? Properties.Resources.download : Properties.Resources.download2;
            lblNomeEx.Enabled = chkNome.Checked;
            lblViceEx.Enabled = chkVice.Checked;
            lblPartidoEx.Enabled = chkPartido.Checked;
            lblNumEx.Enabled = chkNumero.Checked;

            show[0] = chkFoto.Checked;
            show[1] = chkNome.Checked;
            show[2] = chkVice.Checked;
            show[3] = chkPartido.Checked;
            show[4] = chkNumero.Checked;
        }

        private void tabPage2_MouseMove(object sender, MouseEventArgs e)
        {
            chkChanged();

            mouseMove();
        }

        private void rdDefault_CheckedChanged(object sender, EventArgs e)
        {
            soundCheckChanged();

            saved = false;
        }

        private void rdCustom_CheckedChanged(object sender, EventArgs e)
        {
            soundCheckChanged();

            saved = false;
        }

        private void soundCheckChanged()
        {
            if (rdDefault.Checked)
            {
                lblPath.Enabled = false;
                txbPath.Enabled = false;
                btnChoosePath.Enabled = false;

                isDefaultSound = true;
            }
            else if (rdCustom.Checked)
            {
                lblPath.Enabled = true;
                txbPath.Enabled = true;
                btnChoosePath.Enabled = true;

                isDefaultSound = false;
            }

            saved = false;
        }

        private void tbpEnd_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbpEnd_DragDrop(object sender, DragEventArgs e)
        {
            files = (string[]) e.Data.GetData(DataFormats.FileDrop);

            string ext = Path.GetExtension(files[0]).ToLower();

            // Supported: WAV, MP3.

            if (!(ext.Equals(".wav") ||
                  ext.Equals(".mp3")))
            {
                MessageBox.Show("O arquivo selecionado não é suportado. Use apenas arquivos de áudio, como: .wav ou .mp3.", "Arquivo não suportado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                files = null;
                return;
            }

            txbPath.Text = files[0];
            endSound = files[0];
        }

        // Fonte: MSDN Microsoft
        [DllImport("Winmm.dll", SetLastError = true)]
        static extern int mciSendString(string lpszCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnString, int cchReturn, IntPtr hwndCallback);

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isDefaultSound)
            {
                playWAV("Assets/Som.wav");
                return;
            }

            if (files[0] != null)
                endSound = files[0];

            try
            {
                string ext = Path.GetExtension(endSound).ToLower();

                if (ext.Equals(".wav"))
                    playWAV(endSound);
                else if (ext.Equals(".mp3"))
                    playMP3(endSound);
            }
            catch (Exception)
            {
                MessageBox.Show("O caminho especificado não é válido.", "Arquivo de som não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void playMP3(string file)
        {
            // Fonte: MSDN Microsoft

            StringBuilder sb = new StringBuilder();
            string sFileName = file;
            string sAliasName = "MP3";
            int nRet = mciSendString("open \"" + sFileName + "\" alias " + sAliasName, sb, 0, IntPtr.Zero);
            nRet = mciSendString("play " + sAliasName, sb, 0, IntPtr.Zero);
        }

        public void playWAV(string file)
        {
            SoundPlayer sp = new SoundPlayer(file);
            sp.Play();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            ofgSom.ShowDialog();
        }

        private void ofgSom_FileOk(object sender, CancelEventArgs e)
        {
            txbPath.Text = ofgSom.FileName;
            endSound = ofgSom.FileName;
            files[0] = ofgSom.FileName;

            saved = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbFinalPhrase.Text != "")
            {
                finalPhrase = txbFinalPhrase.Text;

                MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("A frase não pode ser vazia.", "Frase vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Testar se não tem Seções na lista
            if (secoes.Count == 0)
            {
                MessageBox.Show("Você não pode iniciar uma votação sem ter uma Seção na lista. Adicione uma clicando em 'Adicionar' abaixo, na guia 'Seções'.", "Lista de Seções Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Testar se uma das Seções não tem candidatos
            for (int i = 0; i < FormLobbyUrna.secoes.Count; i++)
            {
                if (FormLobbyUrna.secoes[i].numCand == 0)
                {
                    MessageBox.Show("A Seção '" + FormLobbyUrna.secoes[i].nome + "' de número " + (i + 1) + ", não tem candidatos. Adicione pelo menos um candidato nela.", "Sem Candidatos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            FormVotar f = new FormVotar();
            f.mode = false;
            actualMode = false;
            FormVotar.repeat = true;

            this.Hide();
            f.Show();
        }

        private void dgvSections_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvSections.Cursor = Cursors.Hand;
        }

        private void dgvSections_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvSections.Cursor = Cursors.Default;
        }

        private void chkBranco_CheckedChanged(object sender, EventArgs e)
        {
            chkChangedAdd();
        }

        private void chkNulo_CheckedChanged(object sender, EventArgs e)
        {
            chkChangedAdd();
        }

        private void chkChangedAdd()
        {
            adicionais[0] = chkBranco.Checked;
            adicionais[1] = chkNulo.Checked;

            saved = false;
        }

        private void changeBoxes(bool[] b1, bool[] b2)
        {
            chkBranco.Checked = b1[0];
            chkNulo.Checked = b1[1];

            chkFoto.Checked = b2[0];
            chkNome.Checked = b2[1];
            chkVice.Checked = b2[2];
            chkPartido.Checked = b2[3];
            chkNumero.Checked = b2[4];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                DialogResult msg = MessageBox.Show("Quer salvar sua urna antes de sair?", "Confirmar Salvamento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (DialogResult.Yes == msg)
                {
                    saved = true;

                    object[] o = { secoes, numSecoes, finalPhrase, isDefaultSound, adicionais[0], adicionais[1], show[0], show[1], show[2], show[3], show[4], endSound, FormSetUrnaName.nomeUrna };

                    Serialization.Serialize(o);
                }
                else if (DialogResult.Cancel == msg)
                    return;

                this.Hide();
                new FormInicio().Show();
            }
            else
            {
                this.Hide();
                new FormInicio().Show();
            }
        }

        private void btnSaveUrna_Click(object sender, EventArgs e)
        {
            saved = true;
            
            object[] o = { secoes, numSecoes, finalPhrase, isDefaultSound, adicionais[0], adicionais[1], show[0], show[1], show[2], show[3], show[4], endSound, FormSetUrnaName.nomeUrna };

            Serialization.Serialize(o);
        }

        private void btnLoadUrna_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Urna do Criador de Urnas (*.urna)|*.urna";
            of.ShowDialog();

            load(of.FileName);
        }

        private void load(string name)
        {
            object[] o = Serialization.Deserialize(name);

            if (o == null) return;

            secoes = (List<Secao>) o[0];
            numSecoes = (int) o[1];
            finalPhrase = (string) o[2];
            isDefaultSound = (bool) o[3];
            adicionais[0] = (bool) o[4];
            adicionais[1] = (bool) o[5];
            show[0] = (bool) o[6];
            show[1] = (bool) o[7];
            show[2] = (bool) o[8];
            show[3] = (bool) o[9];
            show[4] = (bool) o[10];
            endSound = (string) o[11];
            FormSetUrnaName.nomeUrna = (string) o[12];

            updateDeserializedTable();
            changeBoxes(adicionais, show);

            txbFinalPhrase.Text = finalPhrase;

            rdDefault.Checked = isDefaultSound;
            rdCustom.Checked = !isDefaultSound;

            txbPath.Text = endSound;

            saved = true;
        }

        private void FormLobbyUrna_Activated(object sender, EventArgs e)
        {
            foreach (Secao s in secoes) // zerar os votos
            {
                s.branco.votos = 0;
                s.nulo.votos = 0;

                foreach (Candidato c in s.candidatos)
                    c.votos = 0;
            }

            FormVotar.index = 0;
            FormResults.selectedSection = 0;
        }

        private void FormLobbyUrna_Load(object sender, EventArgs e)
        {
            lblNomeUrna.Text = FormSetUrnaName.nomeUrna;
        }

        private void btnStartReal_Click(object sender, EventArgs e)
        {
            // Testar se não tem Seções na lista
            if (secoes.Count == 0)
            {
                MessageBox.Show("Você não pode iniciar uma votação sem ter uma Seção na lista. Adicione uma clicando em 'Adicionar' abaixo, na guia 'Seções'.", "Lista de Seções Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Testar se uma das Seções não tem candidatos
            for (int i = 0; i < FormLobbyUrna.secoes.Count; i++)
            {
                if (FormLobbyUrna.secoes[i].numCand == 0)
                {
                    MessageBox.Show("A Seção '" + FormLobbyUrna.secoes[i].nome + "' de número " + (i + 1) + ", não tem candidatos. Adicione pelo menos um candidato nela.", "Sem Candidatos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (DialogResult.No == MessageBox.Show("Tem certeza de que deseja iniciar uma votação real? Você não poderá retornar para esta tela diretamente depois. Para voltar, você deverá reiniciar a urna. Deseja continuar?", "A votação agora é para valer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            FormVotar f = new FormVotar();
            f.mode = true;
            actualMode = true;
            FormVotar.repeat = true;

            this.Hide();
            f.Show();
        }

        private void txbFinalPhrase_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void tbcMain_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void tbpEnd_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void dgvSections_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            mouseMove();
        }
    }
}
