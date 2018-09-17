using System;
using System.Collections.Generic;
using System.Text;

namespace ex4
{
    class CaixaCanetas
    {
        private int capacidade;
        private double preco;
        private string modelo;

        public CaixaCanetas(int cap, double prec, string mod)
        {
            capacidade = cap;
            preco = prec;
            modelo = mod;
        }

        public CaixaCanetas()
        {
            Console.WriteLine("Object is being created");
        }
        ~CaixaCanetas()
        {   //destructor
            Console.WriteLine("Object is being deleted");
        }

        public void setCapacidade(int cap)
        {
            capacidade = cap;
        }

        public int getCapacidade()
        {
            return capacidade;
        }

        public void setPreco(double pre)
        {
            preco = pre;
        }

        public double getPreco()
        {
            return preco;
        }

        public void setModelo(string str)
        {
            modelo = str;
        }

        public string getModelo()
        {
            return modelo;
        }

        public int calcNumCaixas(int num_canetas)
        {
            return num_canetas / capacidade;
        }

        public int calcPrecoTotal(int num_caixas)
        {
            return capacidade * num_caixas;
        }
    }
}
