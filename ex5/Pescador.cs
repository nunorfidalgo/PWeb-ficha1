using System;
using System.Collections.Generic;
using System.Text;

namespace ex5
{
    class Pescador
    {

        private string Nome { get; set; }
        private string IdPescador { get; }
        public List<Pescaria> Pescarias { get; }

        public Pescador(string nome)
        {
            this.Nome = nome;
            //IdPescaor = Registo.NumeroEntrda (DateTime.Now, "CP);
            Pescarias = new List<Pescaria>();
        }

        public Pescaria AdicionarPescaria(string nome_pescaria)
        {
            if (!Pescarias.Exists(prop => p.Nome == nome_pescaria))
            {
                Pescaria p = new Pescarias(nome_pescaria);
                Pescarias.Add(p);
                return p;
            }
            return null;
        }

    }
}
