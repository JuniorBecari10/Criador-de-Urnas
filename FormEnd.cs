using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Criador_de_Urnas
{
    public partial class FormEnd : Form
    {
        public FormEnd()
        {
            InitializeComponent();
        }

        private void FormEnd_Load(object sender, EventArgs e)
        {
            lblEnd.Text = FormLobbyUrna.finalPhrase;

            if (FormLobbyUrna.isDefaultSound)
            {
                FormLobbyUrna.getLobbyUrna().playWAV("Assets/Som.wav");
                return;
            }

            try
            {
                string ext = Path.GetExtension(FormLobbyUrna.endSound).ToLower();

                if (ext.Equals(".wav")) FormLobbyUrna.getLobbyUrna().playWAV(FormLobbyUrna.endSound);
                else if (ext.Equals(".mp3")) FormLobbyUrna.getLobbyUrna().playMP3(FormLobbyUrna.endSound);
            }
            catch (Exception)
            { return; }
        }

        private void tmrExit_Tick(object sender, EventArgs e)
        {
            this.Hide();

            if (FormVotar.repeat)
            {
                FormVotar.index = 0;

                FormVotar f = new FormVotar();
                f.mode = FormLobbyUrna.actualMode;

                f.Show();
            }
            else
                new FormResults().Show();

            tmrExit.Dispose();
            tmrExit.Enabled = false;
            tmrExit.Stop();
        }
    }
}
