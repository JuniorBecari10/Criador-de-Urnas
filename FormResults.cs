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
    public partial class FormResults : Form
    {
        private DataTable dt;
        private DataTable secDt;

        public static int selectedSection;

        public FormResults()
        {
            InitializeComponent();

            dt = new DataTable();
            secDt = new DataTable();

            dt.Columns.Add("Candidato", typeof(string));
            dt.Columns.Add("Votos", typeof(int));

            secDt.Columns.Add("Seções", typeof(string));

            dgvCandidatos.DataSource = dt;
            dgvCandidatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvViewSections.DataSource = secDt;
            dgvViewSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            this.Text = "Criador de Urnas - Resultado da Votação da Urna: " + FormSetUrnaName.nomeUrna;

            addCandidatos(dt, FormLobbyUrna.secoes[selectedSection]);
            addSections(secDt); 
        }

        private void addCandidatos(DataTable d, Secao s)
        {
            d.Clear();

            foreach (Candidato c in s.candidatos)
                d.Rows.Add(c.nome, c.votos);
        }

        private void addSections(DataTable d)
        {
            foreach (Secao s in FormLobbyUrna.secoes)
                secDt.Rows.Add(s.nome);
        }

        private void FormResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLobbyUrna.getLobbyUrna().Show();
        }

        private void FormResults_MouseMove(object sender, MouseEventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            lblSecao.Text = "Seção: " + FormLobbyUrna.secoes[selectedSection].nome;

            addCandidatos(dt, FormLobbyUrna.secoes[selectedSection]);

            lblBrancos.Text = FormLobbyUrna.secoes[selectedSection].branco.votos.ToString();
            lblNulos.Text = FormLobbyUrna.secoes[selectedSection].nulo.votos.ToString();
        }

        private void dgvViewSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < FormLobbyUrna.secoes.Count) // Burro com B maiúsculo: tem que ser -1 pq 0 é o primeiro :/
                selectedSection = e.RowIndex;

            updateData();
        }

        private void dgvCandidatos_MouseMove(object sender, MouseEventArgs e)
        {
            updateData();
        }

        private void dgvViewSections_MouseMove(object sender, MouseEventArgs e)
        {
            updateData();
        }
    }
}
