using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Criador_de_Urnas
{
    public partial class FormVotar : Form
    {
        // true = normal, false = teste
        public bool mode = true;
        public static bool stMode = true;

        public static int index = 0;

        public static bool repeat = true; // colocar pra true!!

        private int nulo = 0;

        private FormListaCand list;

        public FormVotar()
        {
            InitializeComponent();

            list = new FormListaCand();

            Thread t = new Thread(receive);
            t.Start();
        }

        /**
         * 
         * O método abaixo detecta (em uma thread separada) se a frase "set repeat, false" (ou true) foi enviada pela internet em udp.
         * 
         * Para enviar, defina essas configurações:
         * IP: 10.0.10.230
         * Port: 1111
         * Message: set repeat, false
         * ou
         * set repeat, true
         * 
         * Atenção: o programa só vai detectar se você estiver votando no momento.
         */

        private void receive()
        {
            const int Port = 1111;

            const string rFalse = "'repeat' set to false.";
            const string rTrue = "'repeat' set to true.";

            Byte[] rFalseBuffer = Encoding.ASCII.GetBytes(rFalse);
            Byte[] rTrueBuffer = Encoding.ASCII.GetBytes(rTrue);

            UdpClient cl = null;
            IPEndPoint end = null;

            Socket s = null;
            IPAddress ip = null;
            IPEndPoint ipEnd = null;

            try
            {
                // Receive
                cl = new UdpClient(Port);
                end = new IPEndPoint(IPAddress.Any, 0);

                // Send
                s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            }
            catch (Exception) { }

            while (true)
            {
                try
                {
                    Byte[] rec = cl.Receive(ref end);

                    ipEnd = new IPEndPoint(end.Address, 2222); // eu sempre vou mudar o ipendpoint para o que recebeu :)
                    string data = Encoding.ASCII.GetString(rec);

                    Console.WriteLine("Mensagem recebida: " + data);

                    if (data.Equals("set repeat, false"))
                    {
                        repeat = false;

                        s.SendTo(rFalseBuffer, ipEnd);

                        continue;           // colocamos "continue" e não "return" e nem "break" porque esses dois quebram o loop e não queremos isso, queremos que ele continue recebendo as ordens e o "continue" apenas passa para apróxima iteração.
                    }

                    if (data.Equals("set repeat, true"))
                    {
                        repeat = true;

                        s.SendTo(rTrueBuffer, ipEnd);

                        continue;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private Candidato getVoted(int num)
        {
            Secao s = FormLobbyUrna.secoes[index];

            foreach (Candidato c in s.candidatos)
            {
                if (num == c.numero)
                    return c;
            }

            if (num.ToString().Length == (int)FormLobbyUrna.secoes[index].qtdNum || (num.ToString().Length == 1 && (int)FormLobbyUrna.secoes[index].qtdNum == 0)) // Esse qtdNum quando tem somente 1 dá 0, não sei pq :)
                return FormLobbyUrna.secoes[index].nulo;

            return null;
        }

        // grande sacada né?
        // Pega o candidato com o número escolhido e vê se não retorna null
        private bool candExists(int num)
        {
            return getVoted(num) != null;
        }

        // Mostra na tela o candidato
        private void displayCand(Candidato c, PictureBox foto, Label nome, Label vice, Label numero, Label partido)
        {
            foto.Image = c.foto;
            nome.Text = c.nome;
            vice.Text = c.vice;
            numero.Text = c.numero.ToString();
            partido.Text = c.partido;

            btnConfirmar.Enabled = true;
            foto.Visible = true;
        }

        private void applyConfig(bool[] add, bool[] show)
        {
            btnBranco.Enabled = add[0];

            ptbFoto.Visible = show[0];
            lblNome.Visible = show[1];
            lblVice.Visible = show[2];
            lblPartido.Visible = show[3];
            lblNum.Visible = show[4];
        }

        private void FormVotar_Load(object sender, EventArgs e)
        {
            if (mode)
            {
                this.Text = "Votando para Urna: " + FormSetUrnaName.nomeUrna + ", votar para " + FormLobbyUrna.secoes[index].nome;

                btnReturn.Visible = false;
            }
            else this.Text = "Votando para Urna: " + FormSetUrnaName.nomeUrna + ", votar para " + FormLobbyUrna.secoes[index].nome + " (Teste)";

            txbInput.MaxLength = (int) FormLobbyUrna.secoes[index].qtdNum;

            if (txbInput.MaxLength == 0)
                txbInput.MaxLength = 1;

            lblVote.Text = FormLobbyUrna.secoes[index].nome;

            applyConfig(FormLobbyUrna.adicionais, FormLobbyUrna.show);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ret();
        }

        private void FormVotar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!mode)
                ret();
            else
                Application.Exit();
        }

        private void ret()
        {
            // Limpar todos os votos de todas as Seções
            foreach (Secao s in FormLobbyUrna.secoes)
                foreach (Candidato c in s.candidatos)
                    c.votos = 0;

            this.Hide();
            FormLobbyUrna.getLobbyUrna().Show();
        }

        private void mskInput_TextChanged(object sender, EventArgs e)
        {
            displayCand(getVoted(Convert.ToInt32(txbInput.Text)), ptbFoto, lblNome, lblVice, lblNum, lblPartido);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja votar em branco?", "Confirmação de Voto em Branco", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                return;

            cont(FormLobbyUrna.secoes[index].branco);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (list.IsDisposed)
                list = new FormListaCand();

            list.Show();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza que deseja reiniciar a votação?", "Confirmação de Reinicialização de Votação", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                return;

            FormVotar f = new FormVotar();
            f.mode = mode;

            this.Hide();
            f.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cont(getVoted(Convert.ToInt32(txbInput.Text)));
        }

        private void cont(Candidato c)
        {
            if (!FormLobbyUrna.adicionais[1]) // Se a opção "Nulo" não está marcada, então você não pode votar nulo, pois você apenas pode votar se a opção ESTIVER marcada.
                if (c.numero == nulo)
                    if (DialogResult.OK == MessageBox.Show("Com as configurações atuais, você não pode votar nulo. Por favor reinicie a votação e escolha um número existente.", "Voto Nulo Proibido", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                        return;

            c.votos++;
            index++;

            if (index >= FormLobbyUrna.secoes.Count)
            {
                this.Hide();
                new FormEnd().Show();

                return;
            }

            this.Hide();

            FormVotar f = new FormVotar();
            f.mode = mode;

            f.Show();
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            if (candExists(Convert.ToInt32(txbInput.Text)))
                displayCand(getVoted(Convert.ToInt32(txbInput.Text)), ptbFoto, lblNome, lblVice, lblNum, lblPartido);
        }

        private void txbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Fonte: C# Corner
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 10) // Tabela ASCII (48 - 57 são números)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 10)
                cont(getVoted(Convert.ToInt32(txbInput.Text)));
        }
    }
}
