using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_ConcursoPesca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concurso Pesca!");
            ConcursoPesca c1 = new ConcursoPesca("C1", "Praia dos Piratas");

            //MockData : Tipos de peixe
            TipoPeixe pescada = new TipoPeixe("Pescada", 5);
            TipoPeixe robalo = new TipoPeixe("Robalo", 20);
            TipoPeixe garoupa = new TipoPeixe("Garoupa", 10);

            c1.AdicionarTipoPeixe(pescada);
            c1.AdicionarTipoPeixe(robalo);
            c1.AdicionarTipoPeixe(garoupa);

            //MockData : pescadores + ...
            Pescador gancho = new Pescador("Gancho");
            Pescaria p1 = gancho.AdicionarPescaria("C1.1");
            c1.AdicionarPescador(gancho);

            Pescador barrica = new Pescador("Barrica");
            Pescaria p2 = barrica.AdicionarPescaria("C1.1");
            c1.AdicionarPescador(barrica);

            Pescador marreta = new Pescador("Marreta");
            Pescaria p3 = marreta.AdicionarPescaria("C1.1");
            c1.AdicionarPescador(marreta);

            // O Marreta quer fazer batota!
            c1.AdicionarPescador(marreta);

            // MockData : exemplos de peixes pescados pelos concorrentes
            Peixe x1 = new Peixe(pescada, 100);
            Peixe x2 = new Peixe(pescada, 200);
            Peixe x3 = new Peixe(pescada, 300);

            // MockData : inserir os peixes nas pescarias dos pescadores
            gancho.InserirPeixe(x1, p1);
            barrica.InserirPeixe(x2, p2);
            marreta.InserirPeixe(x3, p3);

            //+este (estava no saco, ... esquecido)
            gancho.InserirPeixe(new Peixe(garoupa, 800), p1);

            //-este (que, entretanto, foi desclassificado)
            marreta.RetirarPeixe(x3, p3);

            //Outra pescaria no mesmo concurso (só para o Marreta)
            Pescaria p4 = marreta.AdicionarPescaria("C1.2");
            marreta.InserirPeixe(new Peixe(garoupa, 600), p4);
            marreta.InserirPeixe(new Peixe(robalo, 1400), p4);

            c1.MostrarDados();
            Console.ReadKey();
        }
    }
}
