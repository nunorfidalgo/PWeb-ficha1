using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int num_canetas, num_caixas;
            Console.WriteLine("Hello World!");

            //CaixaCanetas tipo = new CaixaCanetas();
            //tipo.setCapacidade(1);

            //Console.WriteLine("teste: {0}", tipo.getCapacidade());

            CaixaCanetas Caixa = new CaixaCanetas(10, 2, "bic");

            //Console.WriteLine("capacidade: {0}", Caixa.getCapacidade());
            //Console.WriteLine("preço: {0}", Caixa.getPreco());
            //Console.WriteLine("preço: {0}", Caixa.getModelo());

            //Console.WriteLine("capacidade: {0}, preço: {0}, modelo: {0}.", Caixa.getCapacidade(), Caixa.getModelo(), Caixa.getModelo());
            Console.WriteLine("capacidade: {0}, preço: {0}, modelo: {0}.", Caixa.Capacidade, Caixa.getModelo(), Caixa.getModelo());

            Console.Write("num_canetas: ");
            userInput = Console.ReadLine();
            num_canetas = Convert.ToInt32(userInput);
            Console.WriteLine("calcNumCaixas(30): {0}", Caixa.calcNumCaixas(num_canetas));

            Console.Write("num_caixas: ");
            userInput = Console.ReadLine();
            num_caixas = Convert.ToInt32(userInput);
            Console.WriteLine("calcPrecoTotal(30): {0}", Caixa.calcPrecoTotal(num_caixas));

        }
    }
}
