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
    public partial class FormInicio : Form
    {
        private FormSobre sobre;
        private FormSetUrnaName setName;

        private FormTest1 t1;

        public static string fileName = "";

        private static FormInicio inicio;

        public static bool loaded = false;

        public FormInicio()
        {
            InitializeComponent();

            sobre = new FormSobre();
            setName = new FormSetUrnaName();

            t1 = new FormTest1();

            inicio = this;
        }

        public static FormInicio getFormInicio()
        {
            return inicio;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sobre.IsDisposed)
                sobre = new FormSobre();

            sobre.Show();
        }

        private void btnChooseSavedUrna_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Urna do Criador de Urnas (*.urna)|*.urna";

            o.ShowDialog();

            fileName = o.FileName;

            this.Hide();
            new FormLobbyUrna(true).Show();

            MessageBox.Show("Urna carregada com sucesso!", "Isso aí!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewUrna_Click(object sender, EventArgs e)
        {
            if (setName.IsDisposed)
                setName = new FormSetUrnaName();

            setName.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (t1.IsDisposed)
                t1 = new FormTest1();

            t1.Show();
        }
    }
}
