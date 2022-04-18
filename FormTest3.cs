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
    public partial class FormTest3 : Form
    {
        private bool[] pressed = { false, false };

        public FormTest3()
        {
            InitializeComponent();
        }

        private void FormTest3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pressed[0] = true;
                lblEsq.Font = new Font(lblEsq.Font, FontStyle.Bold);
            }

            if (e.Button == MouseButtons.Right)
            {
                pressed[1] = true;
                lblDir.Font = new Font(lblDir.Font, FontStyle.Bold);
            }
        }

        private void FormTest3_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (bool p in pressed)
                if (!p) return;

            btnContinuar.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTest4().Show();
        }
    }
}
