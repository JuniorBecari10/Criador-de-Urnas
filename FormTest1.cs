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
    public partial class FormTest1 : Form
    {
        private bool[] p;

        public FormTest1()
        {
            InitializeComponent();

            p = new bool[9];

            for (int i = 0; i < 9; i++)
                p[i] = false;
        }

        private void FormTest1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            
            if (k == Keys.D1) p[0] = true;
            if (k == Keys.D2) p[1] = true;
            if (k == Keys.D3) p[2] = true;
            if (k == Keys.D4) p[3] = true;
            if (k == Keys.D5) p[4] = true;
            if (k == Keys.D6) p[5] = true;
            if (k == Keys.D7) p[6] = true;
            if (k == Keys.D8) p[7] = true;
            if (k == Keys.D9) p[8] = true;
            
            if (k == Keys.NumPad1) p[0] = true;
            if (k == Keys.NumPad2) p[1] = true;
            if (k == Keys.NumPad3) p[2] = true;
            if (k == Keys.NumPad4) p[3] = true;
            if (k == Keys.NumPad5) p[4] = true;
            if (k == Keys.NumPad6) p[5] = true;
            if (k == Keys.NumPad7) p[6] = true;
            if (k == Keys.NumPad8) p[7] = true;
            if (k == Keys.NumPad9) p[8] = true;

            if (p[0]) l1.Font = new Font(l1.Font, FontStyle.Bold);
            if (p[1]) l2.Font = new Font(l2.Font, FontStyle.Bold);
            if (p[2]) l3.Font = new Font(l3.Font, FontStyle.Bold);
            if (p[3]) l4.Font = new Font(l4.Font, FontStyle.Bold);
            if (p[4]) l5.Font = new Font(l5.Font, FontStyle.Bold);
            if (p[5]) l6.Font = new Font(l6.Font, FontStyle.Bold);
            if (p[6]) l7.Font = new Font(l7.Font, FontStyle.Bold);
            if (p[7]) l8.Font = new Font(l8.Font, FontStyle.Bold);
            if (p[8]) l9.Font = new Font(l9.Font, FontStyle.Bold);

            foreach (bool b in p)
                if (!b) return;

            btnContinuar.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTest2().Show();
        }
    }
}
