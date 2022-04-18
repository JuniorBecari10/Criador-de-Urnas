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
    public partial class FormTest2 : Form
    {
        private bool[] hovered = { false, false, false, false };

        public FormTest2()
        {
            InitializeComponent();
        }

        private bool allHovered()
        {
            foreach (bool b in hovered)
                if (!b) return false;

            return true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            hovered[0] = true;

            panel1.BackColor = Color.Green;
            btnContinuar.Enabled = allHovered();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            hovered[1] = true;

            panel4.BackColor = Color.Green;
            btnContinuar.Enabled = allHovered();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            hovered[2] = true;

            panel2.BackColor = Color.Green;
            btnContinuar.Enabled = allHovered();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            hovered[3] = true;

            panel3.BackColor = Color.Green;
            btnContinuar.Enabled = allHovered();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTest3().Show();
        }
    }
}
