using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Criador_de_Urnas
{
    [Serializable]
    public class Secao
    {
        public Candidato branco = new Candidato("Branco", "Você votou em Branco.", 0xfff, "", null, "");
        public Candidato nulo = new Candidato("Nulo", "Seu voto será anulado.", 0, "", null, "");

        public string nome { get; set; }
        public int numero { get; set; }
        public int numCand { get; set; }
        public decimal qtdNum { get; set; }

        public List<Candidato> candidatos;

        public Secao(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;

            candidatos = new List<Candidato>();
        }
    }
}
