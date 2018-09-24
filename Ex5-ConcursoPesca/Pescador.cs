using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_ConcursoPesca
{
    class Pescador
    {
        public string Nome { get; set; }
        public string IdPescador { get; }
        public List<Pescaria> Pescarias { get; }

        public Pescador(string nome)
        {
            this.Nome = nome;
            //IdPescador = Registo.NumeroEntrada(DateTime.Now, "CP");
            Pescarias = new List<Pescaria>();
        }


        public Pescaria AdicionarPescaria(string nome_pescaria)
        {
            if (!Pescarias.Exists(p => p.Nome == nome_pescaria))
            {
                Pescaria p = new Pescaria(nome_pescaria);
                Pescarias.Add(p);
                return p;
            }

            return null;
        }


        public void InserirPeixe(Peixe p, Pescaria pescaria)
        {
            if (Pescarias.Contains(pescaria)) pescaria.InserirPeixe(p);
        }


        public void RetirarPeixe(Peixe p, Pescaria pescaria)
        {
            if (Pescarias.Contains(pescaria)) pescaria.RetirarPeixe(p);
        }


        public int Pontuacao(TipoPeixe tp, Pescaria p)
        {
            if (Pescarias.Contains(p)) return p.Pontuacao(tp);
            return 0;
        }


        public int Pontuacao(Pescaria p)
        {
            if (Pescarias.Contains(p)) return p.Pontuacao();
            return 0;
        }


        public int Pontuacao(TipoPeixe tp)
        {
            int n = 0;
            foreach (Pescaria p in Pescarias) n += p.Pontuacao(tp);

            return n;
        }


        public int Pontuacao()
        {
            int n = 0;
            foreach (Pescaria p in Pescarias) n += p.Pontuacao();

            return n;
        }


        public void MostrarDados()
        {
            Console.WriteLine($"\nPescador= {Nome}  Id= {IdPescador} Pontuação Total= {Pontuacao()}");
            foreach (Pescaria p in Pescarias) p.MostrarDados();
        }


        public void MostrarDados(Pescaria p)
        {
            Console.WriteLine($"\nPescador= {Nome}  Id= {IdPescador} Pontuação Total= {Pontuacao(p)}");
            if (Pescarias.Contains(p)) p.MostrarDados();
        }


    }
}
