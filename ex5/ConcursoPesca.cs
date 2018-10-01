using System;
using System.Collections.Generic;
using System.Text;

namespace ex5
{
    class ConcursoPesca
    {
        public List<Pescador> Pescadores { get; }
        public List<TipoPeixe> TiposPeixes { get; }

        public DateTime Data { get; }
        public string Nome { get; }
        public string Local { get; }


        public ConcursoPesca(string nome, string local)
        {
            Pescadores = new List<Pescador>();
            TiposPeixes = new List<TipoPeixe>();

            Data = DateTime.Now;
            Nome = nome;
            Local = local;
        }


        public int AdicionarPescador(Pescador p)
        {
            if (Pescadores.Contains(p)) return 0;
            Pescadores.Add(p);
            return 1;
        }


        public int AdicionarTipoPeixe(TipoPeixe tp)
        {
            if (TiposPeixes.Contains(tp)) return 0;
            TiposPeixes.Add(tp);
            return 1;
        }


        public void MostrarDados()
        {
            Console.WriteLine($"Concurso= {Nome}  Local= {Local}  Data= {Data.ToString()}");

            Console.WriteLine($"\nPeixes no Concurso");
            foreach (TipoPeixe p in TiposPeixes) p.MostrarDados();

            Console.WriteLine($"\nConcorrentes");
            foreach (Pescador p in Pescadores) p.MostrarDados();
        }


    }
}
