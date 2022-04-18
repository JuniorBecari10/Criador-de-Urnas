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
    public partial class FormSetUrnaName : Form
    {
        public static string nomeUrna = "";

        public FormSetUrnaName()
        {
            InitializeComponent();
        }

        private void txbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                continuar();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            continuar();
        }
        
        private void continuar()
        {
            if (txbNome.Text == "" && DialogResult.OK == MessageBox.Show("O nome não pode ser vazio.", "Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            if (txbNome.TextLength > 80 && DialogResult.OK == MessageBox.Show("O nome não pode ter mais que 80 caracteres!", "Tamanho do nome excedeu o limite", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                return;

            nomeUrna = txbNome.Text;

            this.Hide();
            FormInicio.getFormInicio().Hide();

            new FormLobbyUrna(false).Show();
        }
    }
}
