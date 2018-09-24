using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_ConcursoPesca
{
    class TipoPeixe
    {
        public string Nome { get; }
        public int Pontos { get; }
        public DateTime Data { get; }

        public TipoPeixe(string nome, int pontos)
        {
            Nome = nome;
            Pontos = pontos;
            Data = System.DateTime.Now;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"TipoPeixe= {Nome}  Pontos= {Pontos}  Data= {Data.ToString()}");
        }
    }
}
