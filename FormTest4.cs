using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Criador_de_Urnas
{
    public partial class FormTest4 : Form
    {
        public static string msg = "";

        public FormTest4()
        {
            InitializeComponent();
        }

        private void receive()
        {
            const int Port = 1111;

            string msgRetr = "Mensagem recebida: ";

            Byte[] msgBuffer;

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
                    msgRetr = msgRetr.Substring(0, 18);
                    msgRetr += data;
                    msg = data;

                    msgBuffer = Encoding.ASCII.GetBytes(msgRetr);
                    s.SendTo(msgBuffer, ipEnd);

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        // Fonte: StackOverflow
        private string getIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            throw new Exception("Não foi encontrado nenhum IP!");
        }

        private void FormTest4_Load(object sender, EventArgs e)
        {
            lblIP.Text = getIP();

            Thread t = new Thread(receive);
            t.Start();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (msg == null || msg == "") return;

            lblMsg.Text = msg;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Tem certeza de que a mensagem recebida foi a mesma que enviou?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) return;

            MessageBox.Show("Teste da Urna concluído!", "Tudo certo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }
    }
}
