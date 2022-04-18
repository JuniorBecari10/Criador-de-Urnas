using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criador_de_Urnas
{
    public partial class FormEditCandidatos : Form
    {
        public static DataTable dt;
        public static int selectionCellIndex = 0;

        public static FormEditCandidatos frmEdit;

        private FormEditCandidato formEditCand;

        public FormEditCandidatos()
        {
            InitializeComponent();

            frmEdit = this;

            formEditCand = new FormEditCandidato();

            dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Vice", typeof(string));
            dt.Columns.Add("Número", typeof(int));
            dt.Columns.Add("Partido", typeof(string));
            dt.Columns.Add("Caminho da Foto", typeof(string));

            dgvSections.DataSource = dt;
            dgvSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static FormEditCandidatos getFormEdit()
        {
            return frmEdit;
        }

        public void updateList()
        {
            dt.Clear();

            foreach (Candidato c in FormEditSecao.editing.candidatos)
                dt.Rows.Add(c.nome, c.vice, c.numero, c.partido, c.fotoPath);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditSecao.editing.numCand++;

            Candidato c = new Candidato("Vazio", "Vazio", 1, "Vazio", null, "Vazio");
            FormEditSecao.editing.candidatos.Add(c);

            dt.Rows.Add(c.nome, c.vice, c.numero, c.partido, c.fotoPath);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja remover o candidato selecionado?", "Confirmação de remoção de Candidato", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            if (selectionCellIndex < 0) return;

            FormEditSecao.editing.numCand--;

            FormEditSecao.editing.candidatos.RemoveAt(selectionCellIndex);
            dt.Rows.RemoveAt(selectionCellIndex);
        }

        private void FormEditCandidatos_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormEditSecao.editing.numCand == 0)
            {
                btnRemove.Enabled = false;
                btnRemoveLast.Enabled = false;
                btnScopeIn.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnRemoveLast.Enabled = true;
                btnScopeIn.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja limpar a lista de candidatos? \nLembre que essa ação é irreversível.", "Confirmação de Limpeza de Lista", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            FormEditSecao.editing.numCand = 0;
            FormEditSecao.editing.candidatos.Clear();
            dt.Rows.Clear();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja remover o último candidato da lista?", "Confirmação de remoção de Candidato", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            if (FormEditSecao.editing.numCand == 0) return;

            FormEditSecao.editing.numCand--;

            FormEditSecao.editing.candidatos.RemoveAt(FormEditSecao.editing.numCand);
            dt.Rows.RemoveAt(FormEditSecao.editing.numCand);
        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectionCellIndex = e.RowIndex;

            if (selectionCellIndex > dt.Rows.Count) selectionCellIndex = dt.Rows.Count;
            if (selectionCellIndex < 0) selectionCellIndex = 0;
        }

        private void btnScopeIn_Click(object sender, EventArgs e)
        {
            if (formEditCand.IsDisposed)
                formEditCand = new FormEditCandidato();

            formEditCand.Show();
        }

        private void dgvSections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formEditCand.IsDisposed)
                formEditCand = new FormEditCandidato();

            formEditCand.Show();
        }

        private void FormEditCandidatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormEditSecao.editing.candidatos.Count == 1)
                return;

            // Verificar se dois candidatos têm os mesmos valores (nome, vice etc.)
            foreach (Candidato c in FormEditSecao.editing.candidatos)
                foreach (Candidato a in FormEditSecao.editing.candidatos)
                {
                    if (c == a) continue;

                    if (a.nome.Equals(c.nome))
                    {
                        MessageBox.Show("Nessa lista tem 2 candidatos com o mesmos nomes! Altere um deles.", "Nomes duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        break;
                    }

                    if (a.vice.Equals(c.vice))
                    {
                        MessageBox.Show("Nessa lista tem 2 candidatos com o mesmos vices! Altere um deles.", "Vices duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        break;
                    }

                    if (a.numero.Equals(c.numero))
                    {
                        MessageBox.Show("Nessa lista tem 2 candidatos com o mesmos números! Altere um deles.", "Números duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        break;
                    }
                }
        }

        private void FormEditCandidatos_Load(object sender, EventArgs e)
        {
            selectionCellIndex = 0;
        }
    }
}
