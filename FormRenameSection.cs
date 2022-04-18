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
    public partial class FormRenameSection : Form
    {
        public FormRenameSection()
        {
            InitializeComponent();
        }

        private void continuar()
        {
            if (txbNewName.Text == "" && DialogResult.OK == MessageBox.Show("O nome não pode ser vazio.", "Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            if (txbNewName.TextLength > 80 && DialogResult.OK == MessageBox.Show("O nome não pode ter mais que 80 caracteres!", "Tamanho do nome excedeu o limite", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            FormLobbyUrna.secoes[FormLobbyUrna.selectedSectionIndex].nome = txbNewName.Text;

            this.Hide();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            continuar();
        }

        private void FormRenameSection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                continuar();
        }
    }
}
