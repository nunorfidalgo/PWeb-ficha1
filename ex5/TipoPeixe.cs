using System;
using System.Collections.Generic;
using System.Text;

namespace ex5
{
    class TipoPeixe
    {
        private string tipo;
        private int pontos;

        public string Tipo { get; set; }
        public int Pontos { get; set; }

        public TipoPeixe(string t, int p)
        {
            tipo = t;
            pontos = p;
        }

    }
}
