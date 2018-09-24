using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_ConcursoPesca
{
    class Peixe
    {
        public TipoPeixe Tipo { get; set; }
        public int Peso { get; set; }
        public DateTime Data { get; }
        public bool Valido { get; set; }

        //Alínea g) do exercicio

        public int Pontuacao
        {
            get { if (Valido) return Peso * Tipo.Pontos; else return 0; }
        }


        public Peixe(TipoPeixe tipo = null, int peso = 0, bool valido = true)
        {
            Tipo = tipo;
            Peso = peso;
            Valido = valido;
            Data = DateTime.Now;
        }


        public void MostrarDados()
        {
            Console.WriteLine($"Peixe= {Tipo.Nome}  Peso= {Peso}  Valido= {Valido}");
        }
    }
}
