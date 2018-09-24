using System;
using System.Collections.Generic;
using System.Text;

namespace ex5
{
    class Peixe
    {
        public TipoPeixe Pescaria;
        public int Peso { get; set; }
        public bool Valido { get; set; }

        public Peixe(TipoPeixe tp, int p)
        {
            Pescaria = tp;
            Peso = p;
            Valido = true;
        }

    }
}
