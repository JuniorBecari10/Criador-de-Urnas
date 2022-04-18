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

namespace Criador_de_Urnas
{
    public partial class FormEditCandidato : Form
    {

        private string[] files = new string[1];
        public FormEditCandidato()
        {
            InitializeComponent();

            // Erro de executar 2 vezes o DragDrop: Eu estava colocando manualmente aqui, 
            // que no designer automaticamente fazia isso, então ficou 2 eventos, que no FormLobbyUrna, o evento não estava na janela,
            // e sim na TabPage, que não faz isso automaticamente e precisava ser colocada manualmente.

            ofgFoto.Filter = "Arquivos de Imagem|*.png;*.jpg;*.bmp;*.gif";
        }

        private void FormEditCandidato_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void FormEditCandidato_DragDrop(object sender, DragEventArgs e)
        {
            files = (string[]) e.Data.GetData(DataFormats.FileDrop);

            string ext = Path.GetExtension(files[0]).ToLower();

            // Supported: PNG, JPG, BMP e GIF.

            if (!(ext.Equals(".png") ||
                  ext.Equals(".jpg") || 
                  ext.Equals(".bmp") || 
                  ext.Equals(".gif")))
            {
                MessageBox.Show("O arquivo selecionado não é suportado. Use apenas arquivos de imagem, como: .png, .jpg, .bmp e .gif.", "Arquivo não suportado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                files = null;
                return;
            }

            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath = files[0];
            ptbFoto.Image = Image.FromFile(files[0]);
        }

        private void FormEditCandidato_Load(object sender, EventArgs e)
        {
            this.Text = "Criador de Urnas - Editar Candidato: " + FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].nome;

            this.txbNome.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].nome;
            this.txbVice.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].vice;
            this.txbNumero.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].numero.ToString();
            this.txbPartido.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].partido;
            this.txbFoto.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath;

            ptbFoto.Image = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto;
        }

        private void FormEditCandidato_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].nome = this.txbNome.Text;
            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].vice = this.txbVice.Text;
            try
            {
                FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].numero = Convert.ToInt32(this.txbNumero.Text);

                string toStr = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].numero.ToString();

                if (toStr.Length != FormEditSecao.numLengPermitted)
                    if (DialogResult.OK == MessageBox.Show("O número não tem o mesmo número de dígitos especificado. Remova os outros caracteres. \nTamanho especificado: " + FormEditSecao.numLengPermitted + "\nTamanho recebido: " + toStr.Length, "Tamanho não corresponde",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning))
                    {
                        e.Cancel = true;
                    }

                if (txbNumero.Text.Equals("0") && FormLobbyUrna.secoes[FormLobbyUrna.selectedSectionIndex].numCand == 1)
                {
                    MessageBox.Show("O número do candidato não pode ser 0!", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            catch (FormatException)
            {
                if (DialogResult.OK == MessageBox.Show("O número do candidato está inválido. Por acaso você colocou letras nele?", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                    e.Cancel = true;
            }

            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].partido = this.txbPartido.Text;

            if (files[0] != null)
            {
                FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto = Image.FromFile(files[0]);
                FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath = files[0];

                ptbFoto.Image = Image.FromFile(files[0]);
            }

            if (FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath != "Vazio")
            {
                try
                {
                    ptbFoto.Image = Image.FromFile(FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath);
                }
                catch (FileNotFoundException) 
                {
                    try
                    {
                        ptbFoto.Image = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto;
                    }

                    catch (Exception)
                    { }
                }
            }
            else if (FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto != null)
            {
                ptbFoto.Image = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto;
            }
            else
            {
                FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath = "Vazio";
                ptbFoto.Image = null;
            }

            this.txbFoto.Text = files[0];

            FormEditCandidatos.frmEdit.updateList();
        }

        private void FormEditCandidato_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Criador de Urnas - Editar Candidato: " + this.txbNome.Text;

            this.txbFoto.Text = FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath;
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            ofgFoto.ShowDialog();
        }

        private void ofgFoto_FileOk(object sender, CancelEventArgs e)
        {
            files[0] = ofgFoto.FileName;
            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath = files[0];

            ptbFoto.Image = Image.FromFile(files[0]);
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja remover a foto deste candidato?", "Confirmação de Remoção de Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].foto = null;
            FormEditSecao.editing.candidatos[FormEditCandidatos.selectionCellIndex].fotoPath = "Vazio";
            ptbFoto.Image = null;
            
        }
    }
}
