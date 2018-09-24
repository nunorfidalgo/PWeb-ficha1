using System;
using System.Collections.Generic;
using System.Text;

namespace ex5
{
    class TipoPeixe
    {
        private string Tipo;
        private int Pontos;

        public string Tipo { get; set; }
        public int Pontos { get; set; }

        public TipoPeixe(string t, int p)
        {
            Tipo = t;
            Pontos = p;
        }


        public int Pontuacao(TipoPeixe tp)
        {
            int n = 0;
            foreach (Peixe p in Peixes)
                if (p.Tipo == tp) n += p.Pontuacao;
            return n;
        }
    }
}
