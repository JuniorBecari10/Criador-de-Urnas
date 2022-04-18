using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Criador_de_Urnas
{
    static class Serialization
    {
        /* - Serialização -
         * 
         * O processo de serializar consiste em converter objetos e variáveis em uma sequência de bytes em série (por isso o nome),
         * que poderá ser salvo em um arquivo ou enviado através da internet.
         * 
         * O método utiliza o BinaryFormatter para serializar, pois serializa em binário, tornando-o mais difícil a edição externa.
         * 
         * E ainda mostra uma mensagem na tela de que deu certo.
         * 
         * object[] o: O array de objetos (classes) que será serializado.
         * 
         * Por que um array?
         * 
         * Porque nesse método poderão ser serializados vários dados de uma vez só.
         * 
         * Mas onde será salvo?
         * O método tem um sistema embutido que aparece uma caixa de diálogo para o usuário escolher onde quer salvar.
         * 
         */
        public static void Serialize(object[] o)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Urna do Criador de Urnas (*.urna)|*.urna";
            sf.ShowDialog();

            if (sf.FileName == "")
                return;

            FileStream fs = new FileStream(sf.FileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, o);

            fs.Close();

            MessageBox.Show("Salvo com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* - Deserialização -
         * 
         * O processo de deserializar consiste em converter os objetos e variáveis em binário e reconstruí-los de volta. É o contrário de
         * serializar.
         * 
         * Esse método também utiliza o BinaryFormatter para deserializar, como o método de serializar (afinal, temos que serializar e deserializar da mesma maneira, né?)
         * 
         * E o método também não é void, ele retorna um array com todas as coisas que foram deserializadas.
         */
        public static object[] Deserialize(string path)
        {
            if (path == null || path == "") return null;

            object[] da = new object[32767]; // Deserialized Array (DA)

            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            da = (object[]) bf.Deserialize(fs);

            return da;
        }
    }
}
