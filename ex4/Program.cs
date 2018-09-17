using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CaixaCanetas tipo = new CaixaCanetas();
            //tipo.setCapacidade(1);

            //Console.WriteLine("teste: {0}", tipo.getCapacidade());

            CaixaCanetas canetas = new CaixaCanetas(10, 2, "bic");

            Console.WriteLine("capacidade: {0}", canetas.getCapacidade());
            Console.WriteLine("preço: {0}", canetas.getPreco());
            Console.WriteLine("preço: {0}", canetas.getModelo());


        }
    }
}
