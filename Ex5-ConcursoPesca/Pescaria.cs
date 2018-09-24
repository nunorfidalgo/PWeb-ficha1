
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_ConcursoPesca
{
    class Pescaria
    {
        public string Nome { get; }
        public DateTime Data { get; set; }
        public List<Peixe> Peixes { get; set; }

        public Pescaria(string nome)
        {
            Nome = nome;
            Data = DateTime.Now;
            Peixes = new List<Peixe>();
        }


        public void InserirPeixe(Peixe p)
        {
            if (!Peixes.Contains(p)) Peixes.Add(p);
        }


        public void RetirarPeixe(Peixe p)
        {
            if (Peixes.Contains(p)) if (p.Valido) p.Valido = false;
        }


        public int Pontuacao()
        {
            int n = 0;
            foreach (Peixe p in Peixes) n += p.Pontuacao;

            return n;
        }


        public int Pontuacao(TipoPeixe tp)
        {
            int n = 0;
            foreach (Peixe p in Peixes)
                if (p.Tipo == tp) n += p.Pontuacao;

            return n;
        }


        public void MostrarDados()
        {
            Console.WriteLine($"Pescaria= {Nome}  Data= {Data.ToString()} Pontuação = {Pontuacao()}");
            foreach (Peixe p in Peixes) p.MostrarDados();
        }

    }
}
