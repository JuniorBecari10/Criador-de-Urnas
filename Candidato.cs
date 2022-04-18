using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Criador_de_Urnas
{
    [Serializable]
    public class Candidato
    {
        public string nome;
        public string vice;
        public int numero;
        public string partido;
        public Image foto;
        public string fotoPath;
        public int votos;

        public Candidato(string nome, string vice, int numero, string partido, Image foto, string fotoPath)
        {
            this.nome = nome;
            this.vice = vice;
            this.numero = numero;
            this.partido = partido;
            this.foto = foto;
            this.fotoPath = fotoPath;

            votos = 0;
        }
    }
}
