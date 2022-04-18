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
    public partial class FormEditSecao : Form
    {
        private FormRenameSection ren;
        private FormEditCandidatos cand;

        public static int numLengPermitted = 0;

        public static Secao editing;

        public FormEditSecao()
        {
            InitializeComponent();

            editing = FormLobbyUrna.secoes[FormLobbyUrna.selectedSectionIndex];

            cand = new FormEditCandidatos();

            this.Text = "Criador de Urnas - Editar Seção: " + FormLobbyUrna.secoes[FormLobbyUrna.selectedSectionIndex].nome;
            lblNomeSecao.Text = editing.nome;

            ren = new FormRenameSection();

            nmcQtdDgt.Value = clampQtdDgt(editing.qtdNum, nmcQtdDgt.Minimum, nmcQtdDgt.Maximum);
        }

        private decimal clampQtdDgt(decimal v, decimal mn, decimal mx)
        {
            if (v < mn) v = mn;
            if (v > mx) v = mx;

            return v;
        }

        private void EditSecao_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLobbyUrna.getLobbyUrna().Show();
            FormLobbyUrna.updateTable();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (ren.IsDisposed)
                ren = new FormRenameSection();

            ren.Show();
        }

        private void FormEditSecao_MouseMove(object sender, MouseEventArgs e)
        {
            editing = FormLobbyUrna.secoes[FormLobbyUrna.selectedSectionIndex];

            this.Text = "Criador de Urnas - Editar Seção: " + editing.nome;
            lblNomeSecao.Text = editing.nome;

            numLengPermitted = Convert.ToInt32(nmcQtdDgt.Value);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLobbyUrna.getLobbyUrna().Show();
            FormLobbyUrna.updateTable();
        }

        private void assignDataTable(DataTable dt, List<Candidato> list)
        {
            foreach (Candidato c in list)
            {
                dt.Rows.Add(c.nome, c.vice, c.numero, c.partido, c.fotoPath);
            }
        }

        private void btnEditCandidatos_Click(object sender, EventArgs e)
        {
            if (cand.IsDisposed)
                cand = new FormEditCandidatos();

            cand.Text = "Criador de Urnas - Editar Candidatos da Seção: " + editing.nome;
            assignDataTable(FormEditCandidatos.dt, FormEditSecao.editing.candidatos);
            cand.Show();
        }

        private void nmcQtdDgt_ValueChanged(object sender, EventArgs e)
        {
            editing.qtdNum = nmcQtdDgt.Value;
        }
    }
}
