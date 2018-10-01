using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6a
{
    class Utilizador
    {
        private string _Nome;
        private List<Tarefa> _Tarefas;

        public string Nome { get { return _Nome; } } 
        public List<Tarefa> Tarefas { get { return _Tarefas; }  } 

        public Utilizador(string nome)
        {
            _Nome= nome;
            _Tarefas = new List<Tarefa>(); 
            }


        public void AdicionarTarefa(string titulo = null,
            TipoPrioridade prioridade = TipoPrioridade.alta,
            TipoCategoria categoria = TipoCategoria.trabalho,
            TipoEstado estado = TipoEstado.executar,
            string datalimite = null)
        {
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo))
                titulo = "Tarefa";

            if (!DateTime.TryParse(datalimite, out DateTime data)) data = DateTime.Now.AddHours(24);

            Tarefa tarefa = new Tarefa(titulo, prioridade, categoria, estado, data);
            Tarefas.Add(tarefa);
            }


        public IEnumerable<Tarefa> TarefasAtrasadas(DateTime data)
        {
            return from p in Tarefas where p.DataLimite < data && p.Estado != TipoEstado.concluida select p;
            }

        public IEnumerable<Tarefa> ListaDeTarefas(TipoEstado tipo)
        {
            return from p in Tarefas where p.Estado == tipo select p;
            }

        public IEnumerable<Tarefa> ListaDeTarefas(TipoPrioridade tipo)
        {
            return from p in Tarefas where p.Prioridade == tipo select p;
            }

        public IEnumerable<Tarefa> ListaDeTarefas(TipoCategoria tipo)
        {
            return from p in Tarefas where p.Categoria == tipo select p;
            }


        public void MostrarTarefas(string titulo = null, IEnumerable<Tarefa> listadetarefas = null)
        {
            if(titulo != null) Console.WriteLine(titulo);

            foreach (Tarefa p in listadetarefas)
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", p.IdTarefa, p.Titulo, p.Prioridade, p.Categoria, p.Estado, p.DataLimite);
            }
    } 
} 

