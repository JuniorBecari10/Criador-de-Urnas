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
    public partial class FormListaCand : Form
    {
        public FormListaCand()
        {
            InitializeComponent();
        }

        private void FormListaCand_Load(object sender, EventArgs e)
        {
            this.Text = "Lista de Candidatos para " + FormLobbyUrna.secoes[FormVotar.index].nome;

            DataTable dt = new DataTable();

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Vice", typeof(string));
            dt.Columns.Add("Número", typeof(int));
            dt.Columns.Add("Partido", typeof(string));

            dgvLista.DataSource = dt;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dt.Clear();
            addCand(dt, FormLobbyUrna.secoes[FormVotar.index]);
        }

        private void addCand(DataTable dt, Secao s)
        {
            foreach (Candidato c in s.candidatos)
                dt.Rows.Add(c.nome, c.vice, c.numero, c.partido);
        }
    }
}
