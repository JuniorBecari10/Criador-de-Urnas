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
    public partial class FormRename : Form
    {
        public FormRename()
        {
            InitializeComponent();

            txbNewName.Text = FormSetUrnaName.nomeUrna;
        }

        private void txbNewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                continuar();
        }

        private void continuar()
        {
            if (txbNewName.Text == "" && DialogResult.OK == MessageBox.Show("O nome não pode ser vazio.", "Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            if (txbNewName.TextLength > 80 && DialogResult.OK == MessageBox.Show("O nome não pode ter mais que 80 caracteres!", "Tamanho do nome excedeu o limite", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            FormSetUrnaName.nomeUrna = txbNewName.Text;
            FormLobbyUrna.saved = false;

            this.Hide();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            continuar();
        }
    }
}
